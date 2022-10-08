


/* Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84

A (7,-5, 0); B (1,-1,9) -> 11.53 
 */

/* 
ввести
функция находа 3d расстояноя
    путем теоркмы пифагора
вывести
 */

double GD3d(int[] AC, int[] BC)
{
    double Distance = Math.Sqrt
    (
        Math.Pow((AC[0] - BC[0]), 2) +
        Math.Pow((AC[1] - BC[1]), 2) +
        Math.Pow((AC[2] - BC[2]), 2)
    );
    return Distance;
}



int[] AC = { 0, 0, 0 };
int[] BC = { 0, 0, 0 };
int[] ResultCoordinate = { 0, 0, 0 };


Console.Write("Введите число 1 X: ");
int AX = int.Parse(Console.ReadLine());

Console.Write("Введите число 1 Y: ");
int AY = int.Parse(Console.ReadLine());

Console.Write("Введите число 1 Z: ");
int AZ = int.Parse(Console.ReadLine());

Console.WriteLine("-----------------");

Console.Write("Введите число 2 X: ");
int BX = int.Parse(Console.ReadLine());

Console.Write("Введите число 2 Y: ");
int BY = int.Parse(Console.ReadLine());

Console.Write("Введите число 2 Z: ");
int BZ = int.Parse(Console.ReadLine());


AC[0] = AX;
AC[1] = AY;
AC[2] = AZ;

BC[0] = BX;
BC[1] = BY;
BC[2] = BZ;

Console.WriteLine("-----------------");

Console.Write("Distance = ");
Console.Write(GD3d(AC, BC));


/* 
int GD3d(int[] AC, int[] BC)
{
    double Distance = Math.Sqrt
    (
        double.Parse(Math.Pow(double.Parse((AC[0] - BC[0])), 2)) +
        double.Parse(Math.Pow(double.Parse((AC[1] - BC[1])), 2)) +
        double.Parse(Math.Pow(double.Parse((AC[2] - BC[2])), 2))
    );
    return double.Parse(Distance);
}


 */


/* int GD3d(int AX, int AY, int AZ, int BX, int BY, int BZ,)
{
    double Distance = Math.Sqrt(Math.Pow((AX - BX), 2) + Math.Pow((AY - BY), 2) + Math.Pow((AZ - BZ), 2));
    return Distance;
}
 */


/* 
код ищет абсолютный 3д вектор - нето --------------------------------------------------------------

int GetDistance1D(int A, int B)
{
    int[] TempArray = { A, B };
    Array.Sort(TempArray);
    int Distance = TempArray[1] - TempArray[0];
    return Distance;
}

int[] AC = { 0, 0, 0 };
int[] BC = { 0, 0, 0 };
int[] ResultCoordinate = { 0, 0, 0 };



Console.Write("Введите число 1 X: ");
int AX = int.Parse(Console.ReadLine());

Console.Write("Введите число 1 Y: ");
int AY = int.Parse(Console.ReadLine());

Console.Write("Введите число 1 Z: ");
int AZ = int.Parse(Console.ReadLine());

Console.WriteLine("-----------------");

Console.Write("Введите число 2 X: ");
int BX = int.Parse(Console.ReadLine());

Console.Write("Введите число 2 Y: ");
int BY = int.Parse(Console.ReadLine());

Console.Write("Введите число 2 Z: ");
int BZ = int.Parse(Console.ReadLine());


AC[0] = AX;
AC[1] = AY;
AC[2] = AZ;

BC[0] = BX;
BC[1] = BY;
BC[2] = BZ;


ResultCoordinate[0] = GetDistance1D(AC[0], BC[0]);
ResultCoordinate[1] = GetDistance1D(AC[1], BC[1]);
ResultCoordinate[2] = GetDistance1D(AC[2], BC[2]);

Console.WriteLine("-----------------");

Console.Write("3D Distance = ");
Console.Write(ResultCoordinate[0]);
Console.Write(", ");
Console.Write(ResultCoordinate[1]);
Console.Write(", ");
Console.Write(ResultCoordinate[2]);
 */