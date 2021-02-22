using System;
using travel.Models;
using travel.Repositories;

namespace travel.Services
{
  public class TripService
  {
       private readonly TripRepository _repo;
      public TripService(TripRepository repo)
      {
          _repo = repo;
      }
    internal object GetAll()
    {
      throw new NotImplementedException();
    }

    internal object GetById(object id)
    {
      throw new NotImplementedException();
    }

    internal object Create(Trip newTrip)
    {
      throw new NotImplementedException();
    }

    internal object EditTrip(Trip updatedTrip)
    {
      throw new NotImplementedException();
    }

    internal void Delete(int id)
    {
      throw new NotImplementedException();
    }
  }
}