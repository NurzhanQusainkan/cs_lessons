//Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Write("Введите первое число : ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Введите второе число  : ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

Console.Write("Введите третье число : ");
strNum = Console.ReadLine();
int num3 = int.Parse(strNum);

int maxNum;

if (num1 >= num2 && num1 >= num3)
{
   System.Console.WriteLine($"Максимальное число - {num1}");
}
else
{
    if (num2 >= num1 && num2 >= num3 ) 
    {
        System.Console.WriteLine($"Максимальное число - {num2}");
    }
    else 
    {
        System.Console.WriteLine($"Максимальное число - {num3}");
    }

}