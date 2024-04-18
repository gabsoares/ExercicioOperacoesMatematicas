double num1, num2, soma, multiplicacao, divisao, subtracao;
int escolha = 0;

Console.WriteLine("Digite o primeiro numero: ");
num1 = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o segundo numero: ");
num2 = double.Parse(Console.ReadLine());


while (escolha == 0)
{
    Console.WriteLine("Digite o numero: 1-Adição| 2-Subtração| 3- Multiplicacao| 4- Divisao");
    escolha = int.Parse(Console.ReadLine());
    if (escolha == 1)
    {
        soma = num1 + num2;
        Console.WriteLine($"Soma: {soma}");
    }
    else if (escolha == 2)
    {
        subtracao = num1 - num2;
        Console.WriteLine($"Subtracao: {subtracao}");
    }
    else if (escolha == 3)
    {
        multiplicacao = num1 * num2;
        Console.WriteLine($"Multiplicacao: {multiplicacao}");
    }
    else
    {
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
    }
}