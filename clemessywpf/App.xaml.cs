using NLog;
using NLog.Config;
using NLog.Fluent;
using NLog.Targets;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Waf.Applications;
using System.Windows;

namespace clemessywpf
{
    /// <summary>
    /// Logique d'interaction pour App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static readonly Tuple<string, LogLevel>[] logSettings =
        {
            Tuple.Create("App", LogLevel.Info),
            Tuple.Create("ClemessyLib", LogLevel.Warn)
        };

        private static string AppDataPath { get; } = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData),
            ApplicationInfo.ProductName);

        public App()
        {
            var fileTarget = new FileTarget("fileTarget")
            {
                FileName = Path.Combine(AppDataPath, "log", "app.log"),
                Layout = "${date:format=yyyy-MM-dd HH\\:mm\\:ss.ff} ${level} ${processid} ${logger} ${message} ${exception}",
                ArchiveAboveSize = 1024 * 1024 * 5,
                MaxArchiveFiles = 2
            };
            var logConfig = new LoggingConfiguration();
            logConfig.DefaultCultureInfo = CultureInfo.InvariantCulture;
            logConfig.AddTarget(fileTarget);
            var maxLevel = LogLevel.AllLevels.Last();
            foreach (var logSetting in logSettings)
            {
                logConfig.AddRule(logSetting.Item2, maxLevel, fileTarget, logSetting.Item1);
            }
            LogManager.Configuration = logConfig;

        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            LogManager.GetLogger("App").Info("{0} {1} is starting OS: {2}", ApplicationInfo.ProductName, ApplicationInfo.Version, Environment.OSVersion);
        }

        public static void ChangeCulture(string culture)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo(culture);
            Thread.CurrentThread.CurrentUICulture = new CultureInfo(culture);
            var old = Application.Current.MainWindow;

            Application.Current.MainWindow = new MainWindow();
            Application.Current.MainWindow.Show();

            old.Hide();

        }


    }
}
