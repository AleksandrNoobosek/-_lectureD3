// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int num = new Random().Next(10,100);
Console.Write("Рандомное значение: ");
Console.WriteLine(num);

int num1 = num/10;
int num2 = num%10;

if(num1>num2)
{
    Console.Write("наибольшая цифра числа: ");
    Console.WriteLine(num1);
}
else if (num2>num1) 
{
    Console.Write("наибольшая цифра числа: ");
    Console.WriteLine(num2);
}

else if (num1==num2)
{
    Console.Write("они равны: ");
    Console.Write(num1);
    Console.Write("=");
    Console.Write(num2);

}