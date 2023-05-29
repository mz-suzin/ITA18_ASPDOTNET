namespace DemoCep.DTOs;


// bem parecido com o CepModel porque o exemplo é bem simples. Aqui é o modelo de negocio, o que vai ser retornado.
public class CepRespostaDTO
{
    public string Cep { get; set; } = null!;
    public string Estado { get; set; } = null!;
    public string Cidade { get; set; } = null!;
    public string Bairro { get; set; } = null!;
    public string Logradouro { get; set; } = null!;
}