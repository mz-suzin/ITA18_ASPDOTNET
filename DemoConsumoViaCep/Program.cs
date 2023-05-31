
try{
    // System.Console.WriteLine("ConsultarV1: ");
    // var resultado = await ViaCepConsumidor.consultarV1("01001000");
    // Console.WriteLine(resultado.StatusCode);
    // var dados = await resultado.Content.ReadAsStringAsync();
    // System.Console.WriteLine(dados);

    // System.Console.WriteLine("ConsultarV2: ");
    // var resultado = await ViaCepConsumidor.consultarV2("0100100");
    // System.Console.WriteLine(resultado);

    System.Console.WriteLine("Consultar V3: ");
    var resultado = await ViaCepConsumidor.consultarV3("01001000");
    System.Console.WriteLine(resultado.Uf);
}
catch(Exception e)
{
    System.Console.WriteLine(e.Message);;
}
