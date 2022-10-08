//По двум заданным числам проверять является ли первое квадратом второго

Console.Write("введите число: ");
int num1 = int.Parse(Console.ReadLine() ?? "0");

Console.Write("введите число: ");
int num2 = int.Parse(Console.ReadLine()?? "0");

int NumFirst = num1*num1;
int NumSecond = num2*num2;


if(NumFirst==num2)
{
    Console.WriteLine("Первое число яв-ся квадратом второго! ");
}
else
{
    Console.WriteLine("Первое число не яв-ся квадратом второго! ");
}
if(NumSecond==num1)
{
    Console.WriteLine("Второе число яв-ся квадратом первого! ");
}
else
{
    Console.WriteLine("Второе число не яв-ся квадратом первого! ");
}
