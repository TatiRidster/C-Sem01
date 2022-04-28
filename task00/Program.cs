// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите два целых числа");
int numberA = Convert.ToInt32(Console.ReadLine()); 
int numberB = Convert.ToInt32(Console.ReadLine());; 
int Max;

if (numberA > numberB)
   {
       Max = numberA;
   }
   else
   {
       Max = numberB;
   }
Console.WriteLine("Максимум из двух чисел");
Console.WriteLine(Max);