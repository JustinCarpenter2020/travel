using System;
using System.Collections.Generic;
using travel.Models;
using travel.Repositories;

namespace travel.Services
{
  public class VacationService
  {
      private readonly VacationRepository _repo;
      public VacationService(VacationRepository repo)
      {
          _repo = repo;
      }
    internal IEnumerable<Vacation> getAll()
    {
       return _repo.getAll();
    }
  }
}