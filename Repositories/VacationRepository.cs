using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using travel.Models;

namespace travel.Repositories
{
  public class VacationRepository
  {
      //TODO 
      private readonly IDbConnection _db;
      public VacationRepository(IDbConnection db)
      {
          _db = db;
      }
    internal IEnumerable<Vacation> getAll()
    {
      string sql = "SELECT * FROM cruise, trip;";
      return _db.Query<Vacation>(sql);
    }
  }
}