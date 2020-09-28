﻿using StockBook.DataAccess.Data;
using StockBook.DataAccess.Repository.IRepository;
using StockBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace StockBook.DataAccess.Repository
{
    public class CompanyRepository : Repository<Company>, ICompanyRepository
    {
        private readonly ApplicationDbContext _db;

        public CompanyRepository(ApplicationDbContext db)
            :base(db)
        {
            _db = db;
        }

        public void Update(Company company)
        {
            _db.Update(company);
            
        }
    }
}
