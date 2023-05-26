using Microsoft.AspNetCore.Mvc;

namespace DemoHelloWorld.Controllers;


[ApiController]
[Route("[controller]")] //using [controller] gets everything that comes before 'controller'. So in this case = HelloWorld


public class HelloWorldController : ControllerBase {
    private readonly ILogger<HelloWorldController> _logger;

    public HelloWorldController(ILogger<HelloWorldController> logger) //dependency injection
    {
        _logger = logger;
    }

    [HttpGet]
    public string Get() {
        _logger.LogInformation("GET /HelloWorld");
        return "Helloooooo World";
    }

    //Now I want that the person accessing the URI returns me his/her name
    [HttpGet("{name}")] //anything after GET .../HelloWorld/ will be saved to name
    public string Get(string name){
        _logger.LogInformation($"GET /HelloWorld/{name}");
        return $"Helloooooo {name}!!";
    }

    // Now sending the name via query string -- .../HelloWorld/query?name=<name>
    [HttpGet("query")]
    public string GetQuery(string name){
        _logger.LogInformation($"GET /HelloWorld/query?name={name}");
        return $"Helloooooo {name}!!";
    }


}