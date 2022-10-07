//По двум заданным числам проверять является ли первое квадратом второго

Console.Write("введите число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("введите число: ");
int num2 = int.Parse(Console.ReadLine()?? "0");

int num = num1*num1;

if(num==num2)
{
    Console.WriteLine("первое яв-ся квадратом второго! ");
}
else
{
    Console.WriteLine("первое не яв-ся квадратом второго! ");
}