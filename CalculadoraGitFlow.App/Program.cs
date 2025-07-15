Console.WriteLine("Insira um número");
if(!int.TryParse(Console.ReadLine(), out var number1))
{
    Console.WriteLine("Error converting number");
    return;
}


Console.WriteLine("Insira outro número");
if(!int.TryParse(Console.ReadLine(), out var number2))
{
    Console.WriteLine("Error converting number");
    return;
}

Console.WriteLine("Insira um operador");
var operador = Console.ReadLine();
if (string.IsNullOrEmpty(operador))
{
    Console.WriteLine("Invalid operator");
    return;
}

switch (operador)
{
    case "+":
        Console.WriteLine($"A soma é {number1 + number2}");
        break;
    default:
        Console.WriteLine("Invalid operator");
        break;
}

Console.ReadKey();

