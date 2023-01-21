// Найти число которое делится на 7 и на 23 без остатка
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
if(number%7==0 && number%23 ==0) Console.WriteLine("Верно");
else Console.WriteLine("Неверно");

