using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clemessywpf.Models
{
    public class Piece
    {
        public string Reference { get; set; }
        public decimal Tarif { get; set; }
        public DateTime Maj { get; set; }
        public int Statut { get; set; }
    }
}
