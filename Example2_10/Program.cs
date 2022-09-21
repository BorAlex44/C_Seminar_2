using static System.Console;
Clear();
WriteLine("Введите любое трехзначное число: ");
int number = int.Parse(ReadLine()!);
//int temp = number / 10;
//int result = temp % 10;
int result = (number / 10) - (number / 100) * 10;
WriteLine($"Вторая цифра числа {number} это {result}");