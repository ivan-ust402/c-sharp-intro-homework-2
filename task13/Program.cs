/* 
Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

Console.Clear();
Console.WriteLine("Вы находитесь в программе, которая выводит третью цифру введенного вами числа или сообщает, что третьей цифры нет. Для продолжения нажмите Enter...");
Console.ReadLine();

Console.Clear();
Console.WriteLine("Введите число: ");
string number = Console.ReadLine();

if (number.Length > 2) {
    Console.WriteLine($"Третья цифра числа {number} --> {number[2]}");
} else {
    Console.WriteLine($"Третьей цифры нет");
}


