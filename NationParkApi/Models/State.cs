using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace NationalParkApi.Models
{
  public class State
  {
    public State()
    {      
      this.States = new HashSet<StateReserve>();
    }
    public int StateId { get; set; }
    [Required]
    public string StateName { get; set; }
    public virtual ICollection<StateReserve> States { get; set; }
    
  }
}