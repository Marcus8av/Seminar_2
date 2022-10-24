/* Напишите программу, которая принимает на вход трёхзначное число
и на выходе показывает вторую цифру этого числа */

Console.Write("Введите трехзначное число ");

int Number = Convert.ToInt32(Console.ReadLine());

if (Number > 999 || Number < 100) 

{
Console.WriteLine($"Введенное число {Number} не является трехзначным.");
}

else

{
System.Console.WriteLine($"Вторая цифра трехзначного числа { Number / 10 % 10}.");
}

System.Console.WriteLine();
