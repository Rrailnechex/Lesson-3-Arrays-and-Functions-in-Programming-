﻿


/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да */


/*
ввести
превратить в массив
сравнить ячейки массива
написать ответ
*/



Console.Write("Введите пятизначное число: ");
string T5N = Console.ReadLine();

char[] ChA = T5N.ToCharArray();


if (ChA[0] == ChA[4] && ChA[1] == ChA[3])
{
    Console.Write("Да");
}
else
{
    Console.Write("Нет");
}



