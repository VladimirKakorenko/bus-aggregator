using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Services.Catalog.API.Models;

namespace Services.Catalog.API.Controllers;

[ApiController]
public class HomeController : ControllerBase
{
    [Route("/data")]
    public string GetData()
    {
        return "Hello from Data Controller!";
    }

    [Route("/sql")]
    public string GetSqlVersion()
    {
        var cs = @"Server=localhost;Database=TestDb;Trusted_Connection=True;";

        using (var con = new SqlConnection(cs))
        {
            con.Open();

            var version = con.ExecuteScalar<string>("SELECT @@VERSION");

            return version;
        }
    }

    [Route("/sqlcities")]
    public IActionResult GetSqlCitiesAsync()
    {
        var cs = @"Server=localhost;Database=TestDb;Trusted_Connection=True;";

        using (var con = new SqlConnection(cs))
        {
            con.Open();

            var data = con.Query<City>("[dbo].[city_getAll]", commandType: CommandType.StoredProcedure).ToList();

            return new JsonResult(data);
        }
    }
}