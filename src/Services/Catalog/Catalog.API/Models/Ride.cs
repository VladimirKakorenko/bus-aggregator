namespace Services.Catalog.API.Models;

public class Ride
{
    public Guid Id { get; set; }

    public int StartCityId { get; set; }
    public int FinishCityId { get; set; }

    public DateTime StartDate { get; set; }
    public DateTime FinishDate { get; set; }

    public int DriverId { get; set; }
    public int TransportId { get; set; }
}