//Напишите программу, которая принимает на вход два числа и проверяет, 
//является ли одно число квадратом другого.
//5, 25  ->  да
//-4, 16  ->  да
//25, 5  ->  да
//8,9  ->  нет

Console.Clear();
Console.WriteLine("Введите число а:");
int number1=int.Parse(Console.ReadLine());
Console.WriteLine("Введите число а:");
int number2=int.Parse(Console.ReadLine());
int sqr1= number1*number1;
int sqr2= number2*number2;
if (sqr1==number2||sqr2==number1) 
{
    Console.WriteLine("Да");
    }
else
 {
    Console.WriteLine("Нет");
    }