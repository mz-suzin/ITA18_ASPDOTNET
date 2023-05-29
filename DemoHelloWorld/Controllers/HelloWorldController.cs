using Microsoft.AspNetCore.Mvc;
using DemoHelloWorld.DTOs;

namespace DemoHelloWorld.Controllers;


[ApiController]
// We are configuring the routing using attributes.
// Also, using a template for ApiController -> everything inside [] acts as a settling point for the routing
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
    [HttpGet("{name}")] //anything after GET .../HelloWorld/ will be saved to name - just like magic (see API documentation)
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

    [HttpPost]
    public string Post([FromBody] string name)
    {
        _logger.LogInformation($"POST /HelloWorld com {name}");
        return $"Helloooooo {name}!!";
    }

    [HttpPost("Person")]
    public string Post(PersonDTO aPerson)
    {
        _logger.LogInformation($"POST /HelloWorld with {aPerson.Name} age {aPerson.Age}");
        return $"Helloooooo {aPerson.Name}!!";
    }



}