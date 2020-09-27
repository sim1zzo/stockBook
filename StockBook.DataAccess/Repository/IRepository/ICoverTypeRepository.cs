using StockBook.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace StockBook.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
