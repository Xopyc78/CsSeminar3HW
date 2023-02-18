// var stringNumber = "2345s";
// int number;
// bool isNumber = int.TryParse(stringNumber,out number);
// Console.WriteLine(isNumber);
// Console.WriteLine(number);
// if (isNumber)
// {
//     Console.WriteLine("Перевод произошел успешно, в строчке находились только цифры");
//     Console.WriteLine(number);
// }
// else
// {
//     Console.WriteLine("Перевод произошел неуспешно, в строчке находились не только цифры");
//     Console.WriteLine(number);
// }
// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Write("Введите пятизначное положительное число ");
int a = Convert.ToInt32(Console.ReadLine());
if (a < 10000 || a > 99999)
{
    Console.Write("Вы ввели не пятизначное положительное число");
}

else if (a >= 10000 && a <= 99999 && a / 10000 == a % 10 && a / 1000 % 10 == a / 10 % 10)
{
    Console.Write("Данное число является палиндромом");
}
else
{
    Console.Write("Данное число не является палиндромом");
}