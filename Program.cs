// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

Console.Write("Введите трёхзначное число: ");

int number = int.Parse(Console.ReadLine());

int num2 = number / 10 % 10;

if (number > 999)
{
    Console.WriteLine($"Вы ввели не трёхзначное число");
} 

else if (number < 100)
{
    Console.WriteLine($"Вы ввели не трёхзначное число");
}

else 
{
    Console.WriteLine($"Вторая цифра Вашего числа: {num2}");
}

---

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.Write("Введите число: ");

int number = int.Parse(Console.ReadLine());

int num1 = number / 10;

while (num1 > 999)
{
    num1 = num1 / 10;
}

int num2 = num1 % 10;

if (number > 100)
{
Console.WriteLine($"Третья цифра Вашего числа: {num2}");
}

else if (number < 100)
{
    Console.WriteLine($"В Вашем числе нет третьей цифры.");
}

---

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

Console.Write("Введите число от 1 до 7: ");

int number = int.Parse(Console.ReadLine());

if (number > 5)
{
Console.WriteLine($"Это выходной день");
}

else
{
    Console.WriteLine($"Это рабочий день.");
}
