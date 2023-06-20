using LaboratorioRestApi.Database;
using LaboratorioRestApi.Models;
using Microsoft.EntityFrameworkCore;

namespace LaboratorioRestApi.Services;

public class AutorRepositorio : IAutorRepositorio
{
    private readonly DatabaseContext _contexto;
    public AutorRepositorio(DatabaseContext contexto)
    {
        _contexto = contexto;
    }

    public async Task<Autor> AdicionarAsync(Autor Autor)
    {
        await _contexto.AddAsync(Autor);
        await _contexto.SaveChangesAsync();
        return Autor;
    }

    public async Task<Autor> AlterarAsync(Autor Autor)
    {
        var autorDB = await _contexto.Autores.FindAsync(Autor.Id);

        if (autorDB != null)
        {
            autorDB.Livros = Autor.Livros;
            autorDB.PrimeiroNome = Autor.PrimeiroNome;
            autorDB.UltimoNome = Autor.UltimoNome;

            await _contexto.SaveChangesAsync();
        }

        return autorDB;
    }

    public async Task<IEnumerable<Autor?>> ConsultarUltimoNomeAsync(string UltimoNome)
    {
        return await _contexto.Autores
            .Where(ultimoNomeDB => ultimoNomeDB.UltimoNome == UltimoNome)
            .ToListAsync();
    }
}