//Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());
while(x == 0 || y == 0)
{
Console.WriteLine("Координаты не должны быть равны 0, введите повторно ");
Console.Write("Введите x: ");
x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
y = int.Parse(Console.ReadLine());
}
if(x >0 && y >0) Console.WriteLine("Данная точка находится в первой четверти");
else if(x<0 && y>0) Console.WriteLine("Данная точка находится во второй четверти");
else if(x<0 && y<0) Console.WriteLine("Данная точка находится в третьей четверти");
else if(x>0 && y<0) Console.WriteLine("Данная точка находится в четвёртой четверти");
