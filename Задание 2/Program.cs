/* Напишите программу, которая выводит третью цифру заданного числа
или сообщает, что третьей цифры нет. */

System.Console.WriteLine("Введите число: ");
int Number = Convert.ToInt32(Console.ReadLine());

if (Number < 100)
    { 
     Console.WriteLine("Третья цифра отсуствует в введенном числе.");
     return; 
    }

else 

{
while (Number >  999)
    {
    Number = Number /10;      
    }
System.Console.WriteLine($"Третья цифра в числе { Number %10}.");
}

System.Console.WriteLine();
