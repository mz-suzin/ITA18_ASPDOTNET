using System.Net.Http.Json;

public class ViaCepDTO
{
    public string? Cep { get; set; }
    public string? Uf { get; set; }
    public string? Cidade { get; set; }
    public string? Bairro { get; set; }
    public string? Logradouro { get; set; }
}

public class ViaCepConsumidor
{
    public const string URI_BASE = "http://viacep.com.br/ws";
    private static readonly HttpClient cliente = new HttpClient();

    public static Task<HttpResponseMessage> consultarV1(string cep)
    {
        string uri = $"{URI_BASE}/{cep}/json/";
        return cliente.GetAsync(uri);
    }

    public static Task<string> consultarV2(string cep)
    {
        string uri = $"{URI_BASE}/{cep}/json/";
        return cliente.GetStringAsync(uri);
    }

// esse metodo usa agora o namespace system.net.http.json
    public static Task<ViaCepDTO?> consultarV3(string cep)
    {
        string uri = $"{URI_BASE}/{cep}/json/";
        return cliente.GetFromJsonAsync<ViaCepDTO>(uri);
    }
}