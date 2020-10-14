using clemessywpf.Messages;
using clemessywpf.Models;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace clemessywpf.ViewModels
{
    public class PieceViewModel:BaseViewModel
    {
        /*private string _reference;

        public string Reference
        {
            get { return _reference; }
            set { _reference = value; Changed(); }
        }*/
        private Piece _piece;

        public Piece Piece
        {
            get { return _piece; }
            set { _piece = value; Changed(); }
        }


        public ICommand SaveCommand { get; private set; }

        public PieceViewModel(){
            this.SaveCommand = new RelayCommand(SavePiece);
            Messenger.Default.Register<DisplayPieceMessage>(this, message =>
                {
                    this.Piece = message.Piece;
                });
        }

        private void SavePiece()
        {
            //throw new NotImplementedException();
        }
    }
}
