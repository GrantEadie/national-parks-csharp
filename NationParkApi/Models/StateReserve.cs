namespace DungeonApi.Models
{
  public class StateReserve
  {
    public int StateReserveId { get; set; }
    public int StateId { get; set; }
    public int ReserveId { get; set; } 
    public virtual State State { get; set; }
    public virtual Reserve Reserve { get; set; }
  }
}