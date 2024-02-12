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


//Creates an endpoint: //GET /api/hej
[ApiController]
[Route("api")] //prefix for all endpoints
public class MyController : ControllerBase
{
    [HttpGet("hej")]//hej=extra route
    public string Hello()
    {
        return "Hello World!";
    }
}


