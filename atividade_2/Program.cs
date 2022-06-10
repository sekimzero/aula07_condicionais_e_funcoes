// See https://aka.ms/new-console-template for more information
// Business rules:
// IMC = Peso ÷ (Altura × Altura)
//
//Resultado do cálculo do IMC
//Abaixo de 18.5 = Anêmico
//Entre 18.5 e 24.9 = Normal
//Entre 25 e 29.9 = Sobrepeso
//Acima de 30 = Obesidade
//Maior que 40 = Obesidade grave
//
// Utilize a mensagem a seguir como base do retorno esperado:
// Seu diagnóstico é XXXXXX.

double alturaDoUsuarioEntrada;
double pesoDoUsuarioEntrada;

string retornarDiagnosticoDoUsuario(double alturaDoUsuario, double pesoDoUsuario)
{
    double imc = pesoDoUsuario / ( alturaDoUsuario * alturaDoUsuario );

    if ( imc < 18.5 )
    {
        return "Anêmico";
    }
    else if ( imc >= 18.5 && imc < 25 )
    {
        return "Normal";
    }
    else if ( imc >= 25 && imc < 30 )
    {
        return "Sobrepeso";
    }
    else if ( imc >= 30 && imc <= 40 )
    {
        return "Obesidade";
    }
    else if ( imc > 40)
    {
        return "Obesidade grave";
    }
    else
    {
        return "Desconhecido";
    }
}

Console.Write("Qual sua altura em metros: ");
double.TryParse(Console.ReadLine(), out alturaDoUsuarioEntrada);
Console.Write("Qual seu peso em Kg: ");
double.TryParse(Console.ReadLine(), out pesoDoUsuarioEntrada);

Console.WriteLine($"Seu diagnóstico é {retornarDiagnosticoDoUsuario(alturaDoUsuarioEntrada, pesoDoUsuarioEntrada)}");
