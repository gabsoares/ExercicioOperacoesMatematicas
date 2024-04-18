double num1, num2, soma, multiplicacao, divisao, subtracao;

Console.WriteLine("Digite o primeiro numero: ");
num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
num2 = double.Parse(Console.ReadLine());

soma = num1 + num2;
subtracao = num1 - num2;
multiplicacao = num1 * num2;

if (num2 == 0)
{
    Console.WriteLine("Nao divisivel por 0");
}
else if (num2 < 0)
{
    Console.WriteLine("Nao divisivel por numero negativo");
}
else
{
    divisao = num1 / num2;
    Console.WriteLine($"Divisao: {divisao}");
}

Console.WriteLine($"Soma: {soma}\nSubtracao: {subtracao}\nMultiplicacao: {multiplicacao}");
