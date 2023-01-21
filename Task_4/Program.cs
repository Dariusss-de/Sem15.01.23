// Нахождение палиндрома числа 
Console.Write("Ведите число: ");
int number = int.Parse(Console.ReadLine());
int mod = 0;
int newmod = 0;
int i=0;
for(i= number;number!=0;number=number/10)
{
    mod = number % 10;
    newmod = newmod*10 + mod;
}
if(i == newmod) Console.WriteLine("Число палиндром");
else Console.WriteLine("число не является палиндромом");
