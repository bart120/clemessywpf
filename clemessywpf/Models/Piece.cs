using clemessywpf.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clemessywpf.Models
{
    //[Table("pieces_de_voiture")]
    public class Piece : BaseViewModel
    {
        public int ID { get; set; }

        
        private string _reference;

        [Column("ref")]
        public string Reference
        {
            get { return _reference; }
            set { _reference = value; Changed(); }
        }


        public decimal Tarif { get; set; }
        public DateTime Maj { get; set; }
        public int Statut { get; set; }

    }
}
