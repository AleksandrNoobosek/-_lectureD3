
// Показать четные числа от 1 до N

Console.Write("введите число N: ");
int N = int.Parse(Console.ReadLine());


int a = 1;

while (a <= N)
{
	if(a%2==0)
	{
        Console.Write("четное число: ");
		Console.WriteLine(a);
	}
	
	else
	{
		Console.WriteLine("-");
		
	}

	a=a+1;
}	