using clemessywpf.Data;
using clemessywpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clemessywpf.Services
{
    class DbServiceMock : IDbService
    {
        public List<Piece> GetAllPiece()
        {
            return null;
        }

        public ClemessyDbContext getContext()
        {
            throw new NotImplementedException();
        }
    }
}
