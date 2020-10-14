using clemessywpf.Data;
using clemessywpf.Messages;
using clemessywpf.Models;
using clemessywpf.Services;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
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
        public ObservableCollection<Piece> Pieces { get; set; } /*= new ObservableCollection<Piece>
        {
            new Piece{ Reference = "445GGT50", Maj = DateTime.Now, Statut = 1, Tarif = 1234},
            new Piece{ Reference = "445GGT51", Maj = DateTime.Now, Statut = 2, Tarif = 1546},
            new Piece{ Reference = "445GGT53", Maj = DateTime.Now, Statut = 1, Tarif = 16},
        };*/

        private string _searchValue = "445GGT50";
        public string SearchValue
        {
            get { return _searchValue; }
            set { 
                _searchValue = value;
                this.Changed();
            }
        }

        private Piece _selectedPiece;

        public Piece SelectedPiece
        {
            get { return _selectedPiece; }
            set { 
                _selectedPiece = value;
                Messenger.Default.Send<DisplayPieceMessage>(new DisplayPieceMessage { Piece = value });
            }
        }

        public ICommand DeleteCommand { get; private set; }

        private IDbService _servDb;
        //private ClemessyDbContext _db;
        public PieceListViewModel()
        {
            this.DeleteCommand = new RelayCommand(DeletePiece);
            //_db = SimpleIoc.Default.GetInstance<IDbService>().getContext();
            _servDb = SimpleIoc.Default.GetInstance<IDbService>();
            this.Pieces = new ObservableCollection<Piece>(_servDb.GetAllPiece());
            
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
