// Напишите программу, которая принимает на вход
// трёхзначное целое число и на выходе показывает сумму
// первой и последней цифры этого числа.
// 456 => 10
// 782 => 9
// 918 => 17

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int firstDigit = num / 100;
int lustDigit = num % 10;

if (num >= 100 && num <= 999)
{
    int result = firstDigit + lustDigit;
    Console.Write($"Сумма первой и последней цифры = {result}"); //Console.Write("Сумма первой и последней цифры = " + result);
}
else
{
    Console.Write("неправильный ввод");
}