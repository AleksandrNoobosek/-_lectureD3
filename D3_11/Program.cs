//Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число: ");
double num = double.Parse(Console.ReadLine());
if(num > 99)
{
    string Array = num.ToString();
    int size = Array.Length;
    int i = size-3;
    Console.Write("Третья цифра числа слева на право >>");
	Console.WriteLine(Array[2]);
    Console.Write("Третья цифра числа справа на лево ");
    Console.Write(Array[i]);
    Console.WriteLine("<<");
}
else
{
	Console.WriteLine("третей цифры числа нет!");
}

//int num = new Random().Next(1,10000);
//Console.Write("Рандомное значение: ");
//Console.WriteLine(num);
//
//if(num > 99)
//{
//    Console.Write("Третья цифра числа справа на лево ");
//    int result= (num / 100) % 10;
//    Console.WriteLine(result);
//}
//else
//{
//   Console.WriteLine("третей цифры числа нет!");
//}