﻿using KaderBookStore.DataAccess.Data;
using KadersBooks.DataAccess.Repository.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KadersBooks.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork                      //make the method public to access the class
    {
        private readonly ApplicationDbContext _db;    //the usingg statement


        public UnitOfWork(ApplicationDbContext db)     //contructor to use DI and inject in to the repositories
        {
            _db = db;
            Category = new CategoryRepository(_db);
            CoverType = new CoverTypeRepository(_db);
            Product = new ProductRepository(_db);
            SP_Call = new SP_Call(_db);

        }
        public ICategoryRepository Category { get; private set; }
        public ICoverTypeRepository CoverType { get; private set; }
        public IProductRepository Product { get; private set; }
        public ISP_Call SP_Call { get; private set; }



        public void Dispose()
        {
            _db.Dispose();
        }

        public void Save()   //al change will be saved when the save method is called at the 'parent' level
        {
            _db.SaveChanges();

        }
       
    }
}

