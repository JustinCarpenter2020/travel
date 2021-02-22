using System;
using travel.Models;
using travel.Repositories;

namespace travel.Services
{
  public class CruiseService
  {
        private readonly CruiseRepository _repo;
      public CruiseService(CruiseRepository repo)
      {
          _repo = repo;
      }
    internal object GetOne(int id)
    {
      throw new NotImplementedException();
    }

    internal object Create(Cruise newCruise)
    {
      throw new NotImplementedException();
    }

    internal object Edit(Cruise updatedCruise)
    {
      throw new NotImplementedException();
    }

    internal void Delete(int id)
    {
      throw new NotImplementedException();
    }

    internal object GetAll()
    {
      throw new NotImplementedException();
    }
  }
}