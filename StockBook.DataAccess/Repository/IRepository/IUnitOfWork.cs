﻿using System;
using System.Collections.Generic;
using System.Text;

namespace StockBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork :IDisposable
    {
        ICategoryRepository Category { get; }
        ICoverTypeRepository CoverType { get; }
        IProductRepository  Product { get; }
        ICompanyRepository  Company { get; }
        ISP_Call SP_Call { get; }
        void Save();
    }
}
