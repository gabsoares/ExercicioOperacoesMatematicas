double num1 = 0, num2 = 0, num3 = 0, num4 = 0, resultado;
int escolha = 0;

Console.Write("Digite o primeiro numero: ");
num1 = double.Parse(Console.ReadLine());

while(num2 == 0)
{
    Console.Write("Digite o segundo numero: ");
    num2 = double.Parse(Console.ReadLine());
}

do
{
    Console.Write("Digite o terceiro numero: ");
    num3 = double.Parse(Console.ReadLine());
} while (num3 == 0);

for (num4 = 0; num4 == 0;)
{
    Console.Write("Digite o quarto numero: ");
    num4 = double.Parse(Console.ReadLine());
}

while (escolha <= 0 || escolha > 4)
{
    Console.Write("Digite o numero: 1-Adição| 2-Subtração| 3- Multiplicacao| 4- Divisao: ");
    escolha = int.Parse(Console.ReadLine());
    if (escolha == 1)
    {
        resultado = num1 + num2 + num3 + num4;
        Console.WriteLine($"Soma: {resultado}");
    }
    else if (escolha == 2)
    {
        resultado = num1 - num2 - num3 - num4;
        Console.WriteLine($"Subtracao: {resultado}");
    }
    else if (escolha == 3)
    {
        resultado = num1 * num2 * num3 * num4;
        Console.WriteLine($"Multiplicacao: {resultado}");
    }
    else if (escolha == 4)
    {
        if (num2 < 0 || num3 < 0 || num4 < 0)
        {
            Console.WriteLine("Nao divisivel por numero negativo");
        }
        else
        {
            resultado = num1 / num2 / num3 / num4;
            Console.WriteLine($"Divisao: {resultado}");
        }
    }
}