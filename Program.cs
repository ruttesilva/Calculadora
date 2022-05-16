string opcaoDesejada;

Console.WriteLine("--- Calculadora 4 operações ---\n");

Console.WriteLine("(+) Soma");
Console.WriteLine("(-) Subtração");
Console.WriteLine("(x) Multiplicação");
Console.WriteLine("(/) Divisão");

Console.Write("\nSelecione a operação desejada: ");

opcaoDesejada = Console.ReadLine()!;

switch (opcaoDesejada)
{
    case "+":
        Console.WriteLine("Você selecionou soma");

        double soma, somaA, somaB;

        Console.WriteLine("Digite os valores para A + B: ");

        Console.Write("A = ");
        somaA = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("B = ");
        somaB = Convert.ToDouble(Console.ReadLine()!);

        soma = somaA + somaB;

        Console.WriteLine($"Resultado da soma: {somaA} + {somaB} = {soma}");

        break;


    case "-":
        Console.WriteLine("Você selecionou subtração");

        double subtracao, subtracaoA, subtracaoB;

        Console.WriteLine("Digite os valores para A - B: ");

        Console.Write("A = ");
        subtracaoA = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("B = ");
        subtracaoB = Convert.ToDouble(Console.ReadLine()!);

        subtracao = subtracaoA - subtracaoB;

        Console.WriteLine($"Resultado da subtração: {subtracaoA} - {subtracaoB} = {subtracao}");

        break;

    case "x":
        Console.WriteLine("Você selecionou multiplicação");

        double multiplicacao, multiplicacaoA, multiplicacaoB;

        Console.WriteLine("Digite os valores para A x B: ");

        Console.Write("A = ");
        multiplicacaoA = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("B = ");
        multiplicacaoB = Convert.ToDouble(Console.ReadLine()!);

        multiplicacao = multiplicacaoA * multiplicacaoB;

        Console.WriteLine($"Resultado da multiplicacao: {multiplicacaoA} x {multiplicacaoB} = {multiplicacao}");

        break;

    case "/":
        Console.WriteLine("Você selecionou divisão");

        double divisao, divisaoA, divisaoB;

        Console.WriteLine("Digite os valores para A / B: ");

        Console.Write("A = ");
        divisaoA = Convert.ToDouble(Console.ReadLine()!);

        Console.Write("B = ");
        divisaoB = Convert.ToDouble(Console.ReadLine()!);

        divisao = divisaoA / divisaoB;

        Console.WriteLine($"Resultado da divisão: {divisaoA} / {divisaoB} = {divisao}");

        break;

    default:
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Opção inválida.");

        break;
}

Console.WriteLine("\nObrigado por utilizar o programa.");
Console.ResetColor();