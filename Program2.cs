// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
/*
Console.Write("Введите имя: ");
string name = Console.ReadLine();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
Console.WriteLine($"Квадрат {number} равен {number*number}");
Console.WriteLine("Ваше имя "+name);
*/
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1>num2){
    Console.WriteLine($"{num1} большее из двух чисел {num2} меньшее");
    }
else{ 
    Console.WriteLine($"{num2} большее из двух чисел {num1} меньшее");
} 

    