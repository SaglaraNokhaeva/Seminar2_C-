Console.Clear();
int randomNum=new Random().Next(10,100); //74
Console.WriteLine($"Число {randomNum} ");
int a1=randomNum/10; //7
int a2=randomNum%10; //4
int max=a1;
if (a2>max) max=a2;
Console.WriteLine($"Максимальное цифра {max} в числе {randomNum} ");