using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;

namespace ASPDotNetIntro;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        var app = builder.Build();
        app.UseHttpsRedirection();
        app.Run();
    }
}


[ApiController]
[Route("api")]
public class MyController : ControllerBase
{
    [HttpGet("hej")]
    public string Hello()
    {
        return "Hello!";
    }
}

//GET //api/hej
