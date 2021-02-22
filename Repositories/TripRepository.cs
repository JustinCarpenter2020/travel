using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using travel.Models;

namespace travel.Repositories
{
  public class TripRepository
  {
       private readonly IDbConnection _db;
      public TripRepository(IDbConnection db)
      {
          _db = db;
      }
    internal IEnumerable<Trip> GetAll()
    {
      string sql = "SELECT * FROM trip;";
      return _db.Query<Trip>(sql);
    }

    internal Trip GetById(int id)
    {
      string sql = "SELECT * FROM trip WHERE id = @id;";
      return _db.QueryFirstOrDefault<Trip>(sql, new {id});
    }

    internal Trip Create(Trip newTrip)
    {
      string sql = @"
      INSERT INTO trip
      (carRental, hotels, price, finalDestination, title)
      VALUES
      (@CarRental, @Hotels, @Price, @FinalDestination, @Title);
      SELECT LAST_INSERT_ID();";
      int id = _db.ExecuteScalar<int>(sql, newTrip);
      newTrip.Id = id; 
      return newTrip;
    }

    internal Trip Edit(Trip original)
    {
      throw new NotImplementedException();
    }

    internal void Delete(Trip trip)
    {
      throw new NotImplementedException();
    }
  }
}