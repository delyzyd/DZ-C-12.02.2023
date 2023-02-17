  // Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа
// Console.Write("Введите трёхзначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// num = num / 10 % 10;
// Console.WriteLine($"Вторая цифра введённого числа: {num}");

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, 
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
// Console.Write("Введите любое число: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string numStr = Convert.ToString(number);
// int numDigit = numStr.Length;
//     if (numDigit > 2) 
//     {
//         Console.WriteLine($"Третья цифра введённого числа: {numStr[2]}");
//     }
//     else 
//     {
//         Console.WriteLine("третьей цифры нет");
//     }
        

// Задача 15: Напишите программу, которая принимает на вход цифру,
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число от 1 до 7:");
int num = Convert.ToInt32(Console.ReadLine());

    if (num >= 1 && num <= 7)
{
        if (num == 6 | num == 7) 
 System.Console.WriteLine("Сегодня сидим дома");
 if (num == 5)
 System.Console.WriteLine("Зато сегодня пятница можно нажраться");

if (num == 1)
System.Console.WriteLine("Понедельник день тяжелый, но вставать нужно");
else 
System.Console.WriteLine("Вали на работу");
}
else 
{
    System.Console.WriteLine("Не верное число");
}

