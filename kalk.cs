
double a;
double b;
double total;
String oper;


Console.WriteLine("Возможные операции: +, -, *, /");


     Console.WriteLine("Введите a:");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите оператор (+, -, *, /, ^, log):");
oper = Console.ReadLine();

Console.WriteLine("Введите b:");
b = Convert.ToDouble(Console.ReadLine());

switch (oper)
{
    case "+":
        total = a + b;
        Console.WriteLine(a + " + " + b + " = " + total);
        Console.ReadKey(true);
        break;

    case "-":
        total = a - b;
        Console.WriteLine(a + " - " + b + " = " + total);
        Console.ReadKey(true);
        break;

    case "*":
        total = a * b;
        Console.WriteLine(a + " * " + b + " = " + total);
        Console.ReadKey(true);
        break;

    case "/":
        total = a / b;
        Console.WriteLine(a + " / " + b + " = " + total);
        Console.ReadKey(true);
        break;
}
