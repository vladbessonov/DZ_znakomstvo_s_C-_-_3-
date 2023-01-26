// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом. Не используйте строки

// 14212 -> нет
// 12821 -> да
// 23432 -> да

// Ввод исходного значения:
Console.Write("Введите число:  ");
int number = Convert.ToInt32(Console.ReadLine());
// Проверка на "пятизначность"
if (number < 10000 || number > 99999)
{
    Console.WriteLine($"Введеное число {number} не является пятизначным");
    return;
}
// "Переворот" числа:
int num = number; 
int num_rev = 0;
while (num != 0)
{
    num_rev = num_rev * 10;
    num_rev = num_rev + num % 10;
    num = num / 10;
}
// Сравнение чисел и вывод результата:
if (number == num_rev)
    Console.Write($"Число {number} является палиндромом.");
else
    Console.Write($"Число {number} не является палиндромом.");