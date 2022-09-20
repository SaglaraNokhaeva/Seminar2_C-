// Напишите программу, которая будет принимать на вход два числа 
//и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
//34, 5 -> не кратно, остаток 4 
//16, 4 -> кратно


Console.Clear();

Console.WriteLine("Введите число а:");
int number_a=int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b:");
int number_b=int.Parse(Console.ReadLine());

int ostatok=number_a % number_b;

if (ostatok==0) 
{
    Console.WriteLine($"Число {number_a} кратно {number_b}");
    }
else
 {
    Console.WriteLine($"Остаток от деления равен {ostatok}");
    }