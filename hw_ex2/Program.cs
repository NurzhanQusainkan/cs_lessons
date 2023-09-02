// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Write("Enter number : ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Enter number : ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

if (num1 > num2)
{
    System.Console.WriteLine($"{num1} большее число, {num2} меньшее");
}

else
{
    if (num2 > num1) 
{
    System.Console.WriteLine($"{num2} большее число, {num1} меньшее");
}
else
{
    System.Console.WriteLine($"{num1} и {num2} равны");
}
}