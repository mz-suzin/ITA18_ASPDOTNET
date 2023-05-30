using System.ComponentModel.DataAnnotations;

namespace DemoCep.DTOs;


// bem parecido com o CepModel porque o exemplo é bem simples. Aqui é o modelo de negocio, o que vai ser retornado.
public class CepRequisicaoDTO
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
}