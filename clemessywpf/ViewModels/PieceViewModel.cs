﻿using clemessywpf.Messages;
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
        private string _reference;

        public string Reference
        {
            get { return _reference; }
            set { _reference = value; Changed(); }
        }

        public ICommand SaveCommand { get; private set; }

        public PieceViewModel(){
            this.SaveCommand = new RelayCommand(SavePiece);
            Messenger.Default.Register<DisplayPieceMessage>(this, message =>
                {
                    this.Reference = message.Piece.Reference;
                });
        }

        private void SavePiece()
        {
            //throw new NotImplementedException();
        }
    }
}
