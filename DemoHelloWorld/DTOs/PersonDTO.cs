using System;
using System.ComponentModel.DataAnnotations;

namespace DemoHelloWorld.DTOs;

public class PersonDTO
{
    public string Name { get; set; } = null!;
    [Required]

    public int? Age { get; set; }
}