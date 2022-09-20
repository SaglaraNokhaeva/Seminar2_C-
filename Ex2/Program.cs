//11. Напишите программу, которая выводит случайное трёхзначное число и удаляет вторую цифру этого числа.
//456 -> 46
//782 -> 72
//918 -> 98

Console.Clear();
int randomNum=new Random().Next(100,1000); //749
Console.WriteLine($"Число {randomNum} ");
int result=randomNum/100*10+randomNum%10;
Console.WriteLine($"После удаления второй цифры числе {randomNum} получится {result}");