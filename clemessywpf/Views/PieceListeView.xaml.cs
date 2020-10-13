using clemessywpf.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace clemessywpf.Views
{
    /// <summary>
    /// Logique d'interaction pour PieceListeView.xaml
    /// </summary>
    public partial class PieceListeView : UserControl
    {
        private PieceListViewModel _vm;
        public PieceListeView()
        {
            InitializeComponent();
            this.DataContext = _vm = new PieceListViewModel();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this._vm.SearchValue = "";
        }
    }
}
