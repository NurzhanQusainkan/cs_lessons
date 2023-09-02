// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write("Введите число : ");
string strNum = Console.ReadLine();
int number = int.Parse(strNum);

if (number % 2 == 0)
{
    System.Console.WriteLine($"{number} является четным числом");
}

else
{
     System.Console.WriteLine($"{number} не является четным числом");
}


