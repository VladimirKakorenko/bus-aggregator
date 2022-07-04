namespace Services.Catalog.API.Models;

public class Transport
{
    public int Id { get; set; }

    public string Mark { get; set; }
    public string Number { get; set; }

    public virtual IList<Ride> Rides { get; set; }
}