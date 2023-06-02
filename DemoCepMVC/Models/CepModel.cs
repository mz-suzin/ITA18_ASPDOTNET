namespace DemoCepMVC.Models;
using System.ComponentModel.DataAnnotations;



// bem parecido com o CepRespostaDTO porque o exemplo é bem simples. Aqui é a implementação do dev.
// Aqui é uma entidade, deveria ser usado um entity framework. De novo, como o exemplo é simples, nao vamos usar aqui.
public class CepModel
{
    public string Cep { get; set; } = null!;
    public string Estado { get; set; } = null!;
    public string Cidade { get; set; } = null!;
    public string Bairro { get; set; } = null!;
    public string Logradouro { get; set; } = null!;
}

public class CepViewModel //vai ser utilizado tanto pra saida quanto pra entrada de dados
{
    [RegularExpression(@"^\d{8}$", ErrorMessage = "o CEP deve conter exatamente 8 digitos")]
    public string Cep { get; set; } = null!;

    [RegularExpression(@"^[A-Z]{2}$", ErrorMessage = "Estado deve ser uma sigla com duas letras maiúsculas")] //o estado só deve ter duas letras maiusculas
    public string Estado { get; set; } = null!;

    [StringLength(30, ErrorMessage = "Estado deve ter no máximo 70 caracteres")]
    public string Cidade { get; set; } = null!;

    [StringLength(70, ErrorMessage = "Cidade deve ter no máximo 70 caracteres")]
    public string Bairro { get; set; } = null!;
    
    [StringLength(30, ErrorMessage = "Bairro deve ter no máximo 30 caracteres")]
     public string Logradouro { get; set; } = null!;


     public static CepViewModel FromModel(CepModel model)
     {
        return new CepViewModel {
            Cep = model.Cep,
            Cidade = model.Cidade,
            Estado = model.Estado,
            Bairro = model.Bairro,
            Logradouro = model.Logradouro
        };
     }

}