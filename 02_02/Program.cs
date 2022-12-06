// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6


Console.Write("Введите трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

int array = number.ToString().Length;

int result = (number % 10);

if (array < 3 || array > 3)
{
    Console.WriteLine("Введено не трёхзначное число");
}
else
{
    Console.WriteLine("Третье число: " + result);
}
