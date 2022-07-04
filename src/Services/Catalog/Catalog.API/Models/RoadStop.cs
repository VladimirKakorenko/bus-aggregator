namespace Services.Catalog.API.Models;

public class RoadStop
{
    public string Id { get; set; }

    public int CityId { get; set; }
    public string CityName { get; set; }

    public DateTime PlannedDate { get; set; }
    public DateTime? ActualDate { get; set; }
}