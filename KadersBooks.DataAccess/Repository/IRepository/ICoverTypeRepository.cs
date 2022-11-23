﻿using System;
using System.Collections.Generic;
using System.Text;
using KadersBooks.Models;

namespace KadersBooks.DataAccess.Repository.IRepository
{
   public interface ICoverTypeRepository : IRepository<CoverType>
    {
      public void Update(CoverType coverType);
    }
}



