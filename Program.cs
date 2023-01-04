/*Console.WriteLine("Знакомство с языком C#");

: Напишите программу, которая на  вход принимает два числа и выдаёт, какое число большее, а какое меньшее.



Console.Write("Введите первое число : ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число : ");

int num2 = Convert.ToInt32(Console.ReadLine());

if (num1 > num2)
{
    Console.WriteLine(num1 + " больше " + num2 );
}
else
{
   Console.WriteLine(num2 + " больше " + num1 ); 
}

Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.





Console.Write("Введите первое число : ");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число : ");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите третье число : ");

int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 < num2)
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}
if (num1 > max)
{
    max = num1;
}
{
    Console.WriteLine( max + " наибольшее из чисел");
}


Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет


Console.Write("введите число : ");

double number = Convert.ToDouble(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine(" да  " );
}
else
{
    Console.WriteLine("  нет " );
}
/*

Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

5 -> 2, 4
8 -> 2, 4, 6, 8
*/


Console.Write("Введите  число : ");

double numberLast = Convert.ToDouble(Console.ReadLine());

double count = 1;

while (count <= numberLast)
{
    if (count %  2 == 0)
    {
        Console.Write(count  +  "  ");
    }
    count ++;
}
