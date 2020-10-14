using clemessywpf.Services;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace clemessywpf
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            SimpleIoc.Default.Register<IDbService, DbService>();
           
            InitializeComponent();

           

        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            App.ChangeCulture("fr-FR");
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            App.ChangeCulture("en-US");
        }
    }
}
