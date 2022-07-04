namespace Services.Catalog.API.Models;

public class Ride
{
    public string Id { get; set; }

    public int InitialCityId { get; set; }
    public City InitialCity { get; set; }

    public int DriverId { get; set; }
    public Driver Driver { get; set; }

    public int TransportId { get; set; }
    public Transport Transport { get; set; }

    public DateTime PlannedStartDate { get; set; }
    public DateTime? ActualStartDate { get; set; }

    public DateTime PlannedFinishDate { get; set; }
    public DateTime? ActualFinishDate { get; set; }

    public virtual IList<RoadStop> Stops { get; set; }
}