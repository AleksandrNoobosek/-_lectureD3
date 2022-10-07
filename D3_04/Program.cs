//Выяснить является ли число чётным

Console.Write("введите число: ");
int num = int.Parse(Console.ReadLine());


if(num%2==0)
{
    Console.WriteLine("Является четным ");
}
else
{
    Console.WriteLine("не является четным ");
}