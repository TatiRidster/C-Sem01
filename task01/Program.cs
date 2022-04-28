//  Напишите программу, которая принимает на
//  вход три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите три целых числа");
int numberA = Convert.ToInt32(Console.ReadLine()); 
int numberB = Convert.ToInt32(Console.ReadLine());
int numberС = Convert.ToInt32(Console.ReadLine()); 
int Max;
bool x1 = (numberA > numberB);
bool x2 = (numberA > numberС); 
bool x3 = (numberB > numberС);

if (x1 & x2 == true)
   {
       Max = numberA;
   }
   else if (x3==true)
   {
       Max = numberB; 
   }
   else 
    {
        Max=numberС;
    }
Console.WriteLine("Максимум из трех чисел");
Console.WriteLine(Max);