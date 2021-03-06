﻿using clemessywpf.Data;
using clemessywpf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clemessywpf.Services
{
    public class DbService : IDbService
    {

        private ClemessyDbContext _db = new ClemessyDbContext();
        public ClemessyDbContext getContext()
        {
            return _db;
        }

        public List<Piece> GetAllPiece()
        {
            return _db.Pieces.ToList();
        }
    }
}
