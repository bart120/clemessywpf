using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clemessywpf.Models
{
    //[Table("pieces_de_voiture")]
    public class Piece
    {
        public int ID { get; set; }

        [Column("ref")]
        public string Reference { get; set; }

        public decimal Tarif { get; set; }
        public DateTime Maj { get; set; }
        public int Statut { get; set; }

        
    }
}
