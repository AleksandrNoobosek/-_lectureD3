// Выяснить, кратно ли число заданному, если нет, вывести остаток.

int numRan = new Random().Next(10,50);
Console.Write("Рандомное значение: ");
Console.WriteLine(numRan);

Console.Write("введите число: ");
int numTer = int.Parse(Console.ReadLine());
Console.Write("Введенное число: ");
Console.WriteLine(numTer);


if (numRan%numTer==0)
{
    Console.Write("введенное число ");
    Console.Write(numTer);
    Console.Write(" ,кратно рандомно заданному числу ");
    Console.Write(numRan);
}
else if (numTer%numRan==0)
{
    Console.Write("Рандомное число ");
    Console.Write(numRan);
    Console.Write(" ,кратно введенному числу ");
    Console.Write(numTer);
}
else 
{
    Console.Write("введенное число не кратно рандомно заданному числу. ");
    double num1 = numRan % numTer;
    Console.Write("Остаток числа: ");
    Console.Write(num1);
}
