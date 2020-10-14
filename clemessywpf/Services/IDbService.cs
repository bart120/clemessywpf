using clemessywpf.Data;
using clemessywpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clemessywpf.Services
{
    public interface IDbService
    {
        ClemessyDbContext getContext();

        List<Piece> GetAllPiece();
    }
}
