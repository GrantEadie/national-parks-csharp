using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace NationalParkApi.Models
{
  public class Reserve
  {
    public Reserve()
    {      
      this.States = new HashSet<StateReserve>();
    }
    public int ReserveId { get; set; }
    [Required]
    public string ReserveName { get; set; }
    public virtual ICollection<StateReserve> States { get; set; }

  }
}