//  Напишите программу, которая на вход
//принимает два числа и выдаёт, какое число большее, а
//какое меньшее.
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