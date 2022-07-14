namespace Services.Catalog.API.Models;

public class Passenger
{
    public Guid Id { get; set; }
    public string FirstName { get; set; }
    public string Surname { get; set; }
    public string Patronymic { get; set; }
    public string PhoneNumber { get; set; }
}