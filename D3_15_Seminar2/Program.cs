// Найти расстояние между точками в пространстве 2D/3D

int x1 = new Random().Next(0,20);      
int y1 = new Random().Next(0,20);
int z1 = new Random().Next(0,20);

int x2 = new Random().Next(0,20);
int y2 = new Random().Next(0,20);  
int z2 = new Random().Next(0,20);

double distance2D =  Math.Sqrt (Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2));

Console.Write($"Расстояние между точками в пространстве 2D A({x1},{y1}), В({x2},{y2}) = ");
Console.WriteLine(distance2D);                                             

double distance3D =  Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2)+Math.Pow((z2-z1),2)); 

Console.Write($"Расстояние между точками в пространстве 3D A({x1},{y1},{z1}), В({x2},{y2},{z2}) = ");
Console.WriteLine(distance3D);

// int x1 = 2;
// int y1 = 4;
// int z1 = 6;

// int x2 = 6;
// int y2 = 2;
// int z2 = 4;

// 2D = 4.47213595499958
// 3D = 4,898979485566356

