﻿using Dapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace KadersBooks.DataAccess.Repository.IRepository
{
   public interface ISP_Call : IDisposable
    {
        //e.g first column of first row in the result set
        T Single<T>(string procedurename, DynamicParameters param = null);
        //Execute something to the Database but not retrieve anything
        void Execute(string procedurename, DynamicParameters param = null);
        //retrieves the complete row or record
        T OneRecord<T>(string procedurename, DynamicParameters param = null);
        //get all of the rows
        IEnumerable<T>List<T>(string procedurename, DynamicParameters param = null);
        //stored procedure that returns two tables
        Tuple<IEnumerable<T1>, IEnumerable<T2>> List<T1, T2>(string procedurename, DynamicParameters param = null);
    }
}