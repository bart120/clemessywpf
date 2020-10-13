using clemessywpf.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace clemessywpf.ViewModels
{
    public class PieceListViewModel : BaseViewModel
    {
        public ObservableCollection<Piece> Pieces { get; set; } = new ObservableCollection<Piece>
        {
            new Piece{ Reference = "445GGT50", Maj = DateTime.Now, Statut = 1, Tarif = 1234},
            new Piece{ Reference = "445GGT51", Maj = DateTime.Now, Statut = 2, Tarif = 1546},
            new Piece{ Reference = "445GGT53", Maj = DateTime.Now, Statut = 1, Tarif = 16},
        };

        private string _searchValue = "445GGT50";
        public string SearchValue
        {
            get { return _searchValue; }
            set { 
                _searchValue = value;
                this.Changed();
            }
        }

        public Piece SelectedPiece { get; set; }
        public ICommand DeleteCommand { get; private set; }

        public PieceListViewModel()
        {
            this.DeleteCommand = new RelayCommand(DeletePiece);
        }
        
        

        private void DeletePiece()
        {
            if(this.SelectedPiece != null)
                this.Pieces.Remove(this.SelectedPiece);
            //this.Pieces = new List<Piece>(this.Pieces);
            //this.Changed("Pieces");

        }


    }
}
