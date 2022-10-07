//Удалить вторую цифру трёхзначного числа

int num = new Random().Next(100,1000);
Console.Write("Рандомное значение: ");
Console.WriteLine(num);

int FirstNum = (num/100);
int LastNum = num%10;

Console.Write("Первый вариант записи: ");
Console.Write(FirstNum);
Console.WriteLine(LastNum);

int FinishNum = FirstNum*10 + LastNum;
Console.Write("Второй Вариант записи: ");
Console.WriteLine(FinishNum);

int GoogleNum = (num/100*10 + num%10);
Console.Write("Третий Вариант записи: ");
Console.Write(GoogleNum);