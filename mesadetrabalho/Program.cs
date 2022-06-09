// Cotação do dólar no dia 3 de maio de 2022.
double cotacaoDoDolarHoje = 4.97;
const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;

Console.WriteLine("Digite o valor em Real: ");
double.TryParse(Console.ReadLine(), out double valorDaCompraEmReais);

string converterRealParaDolar(double valorDaCompraEmReais)
{

    double valorDisponivelEmDolar = valorDaCompraEmReais / cotacaoDoDolarHoje;
    string result;
    if(VALOR_MINIMO_DE_COMPRA_EM_DOLAR > valorDisponivelEmDolar)
    {
        result =  "A compra mínima permitida é de $" + VALOR_MINIMO_DE_COMPRA_EM_DOLAR;
    }
            
    else if(VALOR_MAXIMO_DE_COMPRA_EM_DOLAR < valorDisponivelEmDolar)
    {
        result = "A compra máxima permitida é de $" + VALOR_MAXIMO_DE_COMPRA_EM_DOLAR;

    }
    else
    {
        result = "Você pode comprar $" + valorDisponivelEmDolar;
    }
    return result;
    
}
Console.WriteLine(converterRealParaDolar(valorDaCompraEmReais));



