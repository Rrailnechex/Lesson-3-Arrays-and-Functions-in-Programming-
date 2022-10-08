


/* Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

/* цикл возведений n раз...*/


Console.Write("Введите число N: ");
int InN = int.Parse(Console.ReadLine());


int TmpX = 0;
int OutN = 1;
int Folse = 0;

Console.Write("Result = ");
while (TmpX <= InN)
{
    if (TmpX != 0)
    {
        OutN = TmpX * TmpX * TmpX;
        Console.Write(OutN); Console.Write(", ");
    }

    TmpX++;
}