//По заданному номеру дня недели вывести его название

Console.WriteLine("Введите порядковый номер дня недели: ");

Console.Write("01, ");
Console.Write("02, ");
Console.Write("03, ");
Console.Write("04, ");
Console.Write("05, ");
Console.Write("06, ");
Console.Write("07. ");

Console.WriteLine("");


int NumDay = int.Parse(Console.ReadLine());
Console.WriteLine("Ваше число: ");
Console.WriteLine(NumDay);



if (NumDay == 01)
{
	Console.Write("День недели: ");
	Console.WriteLine("Monday");
} 

else if (NumDay == 02)

{
	Console.Write("День недели: ");
	Console.WriteLine("Tuesday");
} 

else if (NumDay == 03)

{
	Console.Write("День недели: ");
	Console.WriteLine("Wednesday");
} 

else if (NumDay == 04)

{
	Console.Write("День недели: ");
	Console.WriteLine("Thurday");
}

else if (NumDay == 05)

{
	Console.Write("День недели: ");
	Console.WriteLine("Friday");
}

else if (NumDay == 06)

{
	Console.Write("День недели: ");
	Console.WriteLine("Saturday");
}   

else if (NumDay == 07)

{
	Console.Write("День недели: ");
	Console.WriteLine("Sunday");
}   
else
{
    Console.WriteLine("New day");
}


