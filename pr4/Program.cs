// See https://aka.ms/new-console-template for more information
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
Console.Write("Введите третье число: ");
int num3 = int.Parse(Console.ReadLine());
 int maximum = num1;
if (num2>maximum){
    maximum = num2;
    }
if (num3>maximum){
    maximum = num3;
    }
Console.WriteLine($" большее из трех чисел {maximum} ");
