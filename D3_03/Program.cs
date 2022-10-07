//Найти максимальное из трех чисел


Console.Write("Введите число А: ");
int a = int.Parse(Console.ReadLine());  //int a = int.Parse(Console.Readine ());


Console.Write("введите число B: ");
int b = int.Parse(Console.ReadLine());


Console.Write("введите число C: ");
int c = int.Parse(Console.ReadLine());


int max = a;

if (b>max) 
{
	max = b;
}
else if (c>max) 
{
	max = c;
}

Console.Write("Максимальное значене: ");
Console.Write(max);