// Задать номер четверти, показать диапазоны для возможных координат


Console.Write("Введите номер четверти:");
Console.Write(" 01,");
Console.Write(" 02 ,");
Console.Write(" 03 ,");
Console.WriteLine(" 04 ,");
int x = int.Parse(Console.ReadLine());


if (x==1)
{
    Console.WriteLine("Номер четверти I,диапазоны для возможных координат: x>0 && y>0");
}
else if (x==2)
{
    Console.WriteLine("Номер четверти II,диапазоны для возможных координат: x<0 && y>0");
}
else if (x==3)
{
    Console.WriteLine("Номер четверти III,диапазоны для возможных координат: x<0 && y<0  ");
}
else if (x==4) 
{
    Console.WriteLine("Номер четверти IV,диапазоны для возможных координат: x>0 && y<0  ");
}

else  
{
    Console.WriteLine("Введено некорректное значение");
}