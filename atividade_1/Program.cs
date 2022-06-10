// See https://aka.ms/new-console-template for more information
// Cotação do dólar no dia 3 de maio de 2022.
double cotacaoDoDolarHoje;
double valorDaCompraUsuario;
double valorDaCompraEmDolares;

const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;

double converterRealParaDolar(double valorDaCompraEmReais)
{
    return valorDaCompraEmReais / cotacaoDoDolarHoje;
}

// Utilize as mensagens a seguir como base do retorno esperado:
// A compra mínima permitida é de $ XXX,XX.
// A compra máxima permitida é de $ XXXX,XX.
// Você pode comprar $ XXX,XX.
Console.Write("Informe a cotação de hoje do dolar em R$: ");
double.TryParse(Console.ReadLine(), out cotacaoDoDolarHoje);

Console.WriteLine("\n\nSeus limites:\n");
Console.WriteLine($"Mínimo: $ {VALOR_MINIMO_DE_COMPRA_EM_DOLAR} = R$ {VALOR_MINIMO_DE_COMPRA_EM_DOLAR * cotacaoDoDolarHoje} pela cotaçao de R$/$ {cotacaoDoDolarHoje}");
Console.WriteLine($"Máximo: $ {VALOR_MAXIMO_DE_COMPRA_EM_DOLAR} = R$ {VALOR_MAXIMO_DE_COMPRA_EM_DOLAR * cotacaoDoDolarHoje} pela cotaçao de R$/$ {cotacaoDoDolarHoje}");
Console.Write("\n\nInforme o valor de sua compra em R$: ");

double.TryParse(Console.ReadLine(), out valorDaCompraUsuario);
valorDaCompraEmDolares = converterRealParaDolar(valorDaCompraUsuario);

Console.WriteLine("\n\nResultado");
if (valorDaCompraEmDolares < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
{
    Console.WriteLine($"A compra mínima permitida é de $ {VALOR_MINIMO_DE_COMPRA_EM_DOLAR}");

} else if (valorDaCompraEmDolares > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
{
    Console.WriteLine($"A compra máxima permitida é de $ {VALOR_MAXIMO_DE_COMPRA_EM_DOLAR}");
}
else
{
    Console.WriteLine($"Você pode comprar ${valorDaCompraEmDolares} por R$ {valorDaCompraUsuario}");
}
