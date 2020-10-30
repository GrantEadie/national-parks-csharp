using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NationalParkApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace NationalParkApi.Controllers
{
  [Authorize]
  [Route("api/[controller]")]
  [ApiController]
  public class StatesController : ControllerBase
  {
    private NationalParkApiContext _db;

    public StatesController(NationalParkApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<State>> Get(int Id)
    {
      var query = _db.States.AsQueryable();

      if (Id != 0)
      {
        query = query.Where(entry => entry.StateId == Id);
      }
      
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] State state, int ReserveId)
    {
      _db.States.Add(state);
      if (ReserveId != 0)
      {
        _db.StateReserves.Add(new StateReserve() { ReserveId = ReserveId, StateId = state.StateId });
      }
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] State state)
    {
      state.StateId = id;
      _db.Entry(state).State = EntityState.Modified;
      _db.SaveChanges();
    }
    
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var stateToDelete = _db.States.FirstOrDefault(entry => entry.StateId == id);
      _db.States.Remove(stateToDelete);
      _db.SaveChanges();
    }
  }
}



