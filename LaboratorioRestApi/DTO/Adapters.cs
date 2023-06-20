using LaboratorioRestApi.Models;

namespace LaboratorioRestApi.DTO;

public class Adapters
{
    public static AutorDTO toDto(Autor autor)
    {
        var dto = new AutorDTO();
        dto.Id = autor.Id;
        dto.PrimeiroNome = autor.PrimeiroNome;
        dto.UltimoNome = autor.UltimoNome;
        return dto;
    }

    public static Autor toModel(AutorDTO autorDto)
    {
        var autor = new Autor();
        autor.Id = autorDto.Id.GetValueOrDefault();
        autor.PrimeiroNome = autorDto.PrimeiroNome;
        autor.UltimoNome = autorDto.UltimoNome;
        return autor;
    }

//MUDAR AQUI PRA LIVRO E EMPRESTIMO
    // public static AutorDTO toDto(Autor autor)
    // {
    //     var dto = new AutorDTO();
    //     dto.Id = autor.Id;
    //     dto.PrimeiroNome = autor.PrimeiroNome;
    //     dto.UltimoNome = autor.UltimoNome;
    //     return dto;
    // }

    // public static Autor toModel(AutorDTO autorDto)
    // {
    //     var autor = new Autor();
    //     autor.Id = autorDto.Id.GetValueOrDefault();
    //     autor.PrimeiroNome = autorDto.PrimeiroNome;
    //     autor.UltimoNome = autorDto.UltimoNome;
    //     return autor;
    // }

    // public static AutorDTO toDto(Autor autor)
    // {
    //     var dto = new AutorDTO();
    //     dto.Id = autor.Id;
    //     dto.PrimeiroNome = autor.PrimeiroNome;
    //     dto.UltimoNome = autor.UltimoNome;
    //     return dto;
    // }

    // public static Autor toModel(AutorDTO autorDto)
    // {
    //     var autor = new Autor();
    //     autor.Id = autorDto.Id.GetValueOrDefault();
    //     autor.PrimeiroNome = autorDto.PrimeiroNome;
    //     autor.UltimoNome = autorDto.UltimoNome;
    //     return autor;
    // }
}