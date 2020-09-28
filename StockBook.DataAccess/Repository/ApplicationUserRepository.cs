using StockBook.DataAccess.Data;
using StockBook.DataAccess.Repository.IRepository;
using StockBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace StockBook.DataAccess.Repository
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IApplicationUserRepository
    {
        private readonly ApplicationDbContext _db;

        public ApplicationUserRepository(ApplicationDbContext db)
            :base(db)
        {
            _db = db;
        }

        
    }
}
