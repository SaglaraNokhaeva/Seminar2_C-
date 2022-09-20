//Напишите программу, которая принимает на вход число и проверяет, 
//кратно ли оно одновременно 7 и 23.
//14 -> нет 
//46 -> нет 
//161 -> да

Console.Clear();
Console.WriteLine("Введите число а:");
int number=int.Parse(Console.ReadLine());
int ostatok1=number % 7;
int ostatok2=number % 23;
if (ostatok1==0 && ostatok2==0) 
{
    Console.WriteLine($"Число {number} кратно 7 и 23");
    }
else
 {
    Console.WriteLine($"Число {number} не кратно 7 и 23");
    }