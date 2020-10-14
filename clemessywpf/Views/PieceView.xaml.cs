﻿using clemessywpf.ViewModels;
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
    /// Logique d'interaction pour PieceView.xaml
    /// </summary>
    public partial class PieceView : UserControl
    {

        private PieceViewModel _vm;
        public PieceView()
        {
            this.DataContext = _vm = new PieceViewModel();
            InitializeComponent();

        }
    }
}
