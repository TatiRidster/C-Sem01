// Напишите программу, которая на вход
//принимает число и выдаёт, является ли число чётным
//(делится ли оно на два без остатка).

Console.WriteLine("Введите целое число");
double numberA = Convert.ToInt32(Console.ReadLine());

if (numberA % 2 == 0)
 {
     Console.WriteLine("Ваше число четное");
 }
 else
 {
     Console.WriteLine("Ваше число нечетное");
 }