using Microsoft.AspNetCore.Mvc;
//Download postman-connect

namespace ASPDotNetIntro;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        builder.Services.AddControllers(); //Look&Finds for all controllers 

        var app = builder.Build();

        app.MapControllers();//Map all controllers-connecting the routes to methods
        app.UseHttpsRedirection();
        app.Run();
    }
}


public class User
{
    public string Name { get; set; }
    public string Password { get; set; }

    public User(string name, string password)
    {
        this.Name = name;
        this.Password = password;
    }
}

//Creates an endpoint: //GET /api/hej
[ApiController]
[Route("api")] //prefix for all endpoints
public class MyController : ControllerBase
{
    [HttpGet("hej")]//hej=extra route
    public User Hello()
    {
        return new User("Ironman", "tonystark123"); //DEFAULT JSON
    }
}


