using DemoCep.DTOs;

namespace DemoCep.Models;


// bem parecido com o CepRespostaDTO porque o exemplo é bem simples. Aqui é a implementação do dev.
// Aqui é uma entidade, deveria ser usado um entity framework. De novo, como o exemplo é simples, nao vamos usar aqui.
public class CepModel
{
    public string Cep { get; set; } = null!;
    public string Estado { get; set; } = null!;
    public string Cidade { get; set; } = null!;
    public string Bairro { get; set; } = null!;
    public string Logradouro { get; set; } = null!;
    public static CepRespostaDTO ParaDTO(CepModel model)
    {
        return new CepRespostaDTO {
            Cep = model.Cep,
            Estado = model.Estado,
            Cidade = model.Cidade,
            Bairro = model.Bairro,
            Logradouro = model.Logradouro
        };
        
    }
}