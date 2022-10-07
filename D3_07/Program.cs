// Показать вторую цифру трёхзначного числа

int num = new Random().Next(100,1000);
Console.Write("Рандомное значение: ");
Console.WriteLine(num);

int LastNum = ((num/10)%10);
Console.Write("вторуя цифра трёхзначного числа: ");
Console.WriteLine(LastNum);