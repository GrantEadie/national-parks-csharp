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
    public ActionResult<IEnumerable<State>> Get(string stateName)
    {
      var query = _db.States.AsQueryable();

      if (stateName != null)
      {
        query = query.Where(entry => entry.StateName == stateName);
      }
      
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] State state)
    {
      _db.States.Add(state);
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