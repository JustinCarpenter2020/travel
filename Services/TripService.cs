using System;
using System.Collections.Generic;
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
    internal IEnumerable<Trip> GetAll()
    {
      return _repo.GetAll();
    }

    internal Trip GetById(int id)
    {
      Trip trip = _repo.GetById(id);
      if(trip == null)
      {
          throw new Exception("invalid id");
      }
      return trip;
    }

    internal Trip Create(Trip newTrip)
    {
      return _repo.Create(newTrip);
    }

    internal Trip EditTrip(Trip updatedTrip)
    {
      Trip original = GetById(updatedTrip.Id);
      // TODO MORE HERE
       original.Hotels = updatedTrip.Hotels != 0 ? updatedTrip.Hotels : original.Hotels;
      return _repo.Edit(original);
    }

    internal string Delete(int id)
    {
      Trip trip = GetById(id);
      _repo.Delete(trip);
      return "Deleted";
    }
  }
}