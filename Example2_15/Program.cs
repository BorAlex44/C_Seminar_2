using static System.Console;
Clear();
WriteLine("Введите число - день недели: ");
int numberDay = int.Parse(ReadLine()!);
if (numberDay > 7)
{
    WriteLine($"Нет такого дня недели!!!!!!");
    return;
}
if (numberDay == 6 || numberDay == 7)
{
    WriteLine($"УРА сегодня выходной");
}
else
{
    WriteLine($"Увы сегодня рабочий день");
}