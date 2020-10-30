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
  public class ReservesController : ControllerBase
  {
    private NationalParkApiContext _db;

    public ReservesController(NationalParkApiContext db)
    {
      _db = db;
    }

    [HttpGet]
    public ActionResult<IEnumerable<Reserve>> Get(int Id)
    {
      var query = _db.Reserves.AsQueryable();

      if (Id != 0)
      {
        query = query.Where(entry => entry.ReserveId == Id);
      }
      
      return query.ToList();
    }

    [HttpPost]
    public void Post([FromBody] Reserve reserve, int MainTypeId)
    {
      _db.Reserves.Add(reserve);
      if (MainTypeId != 0)
      {
        _db.ReserveMainTypes.Add(new ReserveMainType() { MainTypeId = MainTypeId, ReserveId = reserve.ReserveId });
      }
      _db.SaveChanges();
    }

    [HttpPut("{id}")]
    public void Put(int id, [FromBody] Reserve reserve)
    {
      reserve.ReserveId = id;
      _db.Entry(reserve).State = EntityState.Modified;
      _db.SaveChanges();
    }
    
    [HttpDelete("{id}")]
    public void Delete(int id)
    {
      var reserveToDelete = _db.Reserves.FirstOrDefault(entry => entry.ReserveId == id);
      _db.Reserves.Remove(reserveToDelete);
      _db.SaveChanges();
    }
  }
}



