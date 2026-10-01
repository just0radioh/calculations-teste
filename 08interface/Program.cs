Icalculadorabase c = new Calculadora();
Console.WriteLine("Calculo basico - escolha qual operação deseja realizar");
Console.WriteLine("1 - Soma");
Console.WriteLine("2 - Subtração");
Console.WriteLine("3 - Multiplicação");
Console.WriteLine("4 - Divisão");

string? escolha = Console.ReadLine();

switch (escolha)
{
    case "1":
        Console.WriteLine("Resultado: " + c.soma());
        break;
    case "2":
        Console.WriteLine("Resultado: " + c.subtracao());
        break;
    case "3":
        Console.WriteLine("Resultado: " + c.multiplicacao());
        break;
    case "4":
        Console.WriteLine("Resultado: " + c.divisao());
        break;
    default:
        Console.WriteLine("Opção inválida");
        break;                  
{
}
}
