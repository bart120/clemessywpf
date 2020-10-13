using clemessywpf.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clemessywpf.ViewModels
{
    public class PieceListViewModel : BaseViewModel
    {
        public List<Piece> Pieces { get; set; } = new List<Piece>
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

    }
}
