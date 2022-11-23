using KaderBookStore.DataAccess.Data;
using KadersBooks.DataAccess.Repository.IRepository;
using KadersBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KadersBooks.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private readonly ApplicationDbContext _db;
        public CoverTypeRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }
        public void Update(CoverType coverType)
        {
            //use  .NET LINQ to retrieve the first or default category object
            //then pass the id as a generic entity which matches the category ID

            var objFromDb = _db.CoverTypye.FirstOrDefault(s => s.Id == coverType.Id);
            if (objFromDb != null) //save changes if not null
            {
                objFromDb.Name = coverType.Name;

            }


        }
    }
}



