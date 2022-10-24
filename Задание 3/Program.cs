/* Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным. */

System.Console.WriteLine("Введите числовое значение дня недели:");
int num = Convert.ToInt32(Console.ReadLine());

if (num == 6 || num == 7)
{
Console.WriteLine("Это выходной день, но скоро опять будние дни.");
}
else if (num < 1 || num > 7)
{
    Console.WriteLine("Данная цифра не является днем недели, их всего лишь семь.");
} 
else Console.WriteLine("Это будний день, но выходные скоро.");

System.Console.WriteLine();
