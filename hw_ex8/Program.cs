// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
Console.Write("Введите число N: ");
string strNum = Console.ReadLine();
int N = int.Parse(strNum);

Console.WriteLine("Четные числа от 1 до N: ");

int i = 2;
while (i <= N)
{
    System.Console.WriteLine(i);
    i += 2;
}