using static System.Console;
Clear();
WriteLine("Введите любое число: ");
int number = int.Parse(ReadLine()!);
int temp = 0;
if (number / 100 == 0)
{
    WriteLine("У данного числа нет третьей цифры");
    return;
}
if (number / 1000 == 0)
{
    temp = number % 10;
}
while (number / 1000 != 0)
{
    number = number / 10;
    temp = number % 10;
}
WriteLine($"Третья цифра введенного числа - {temp}");