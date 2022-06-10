

Console.WriteLine("Insira seu peso em quilos");
double pesoDoUsuario = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Insira sua altura em metros");
double alturaDoUsuario = Convert.ToDouble(Console.ReadLine());

static string RetornarDiagnosticoDoUsuario(double pesoDoUsuario, double alturaDoUsuario)
{
    double imc = pesoDoUsuario / (alturaDoUsuario * alturaDoUsuario);


    return imc switch
    {
        < 18.5 => "Anêmico",
        >= 18.5 and < 25 => "Normal",
        >= 25 and < 30 => "Sobrepeso",
        >= 30 and < 40 => "Obesidade",
        >= 40 => "Obesidade Grava",
        _ => "Valor "
    };
};

Console.WriteLine($"Seu diagnóstico é {RetornarDiagnosticoDoUsuario(pesoDoUsuario, alturaDoUsuario)}");

