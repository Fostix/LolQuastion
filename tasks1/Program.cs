﻿//  Группа начинающих программистов решила поучаствовать в хакатоне с целью демонстрации
своих навыков.

 Немного подумав они вспомнили, что не так давно на занятиях по математике
 они проходили тему "свойства делимости целых чисел".На этом занятии преподаватель показывал
 пример с использованием фактов делимости.
 Пример заключался в следующем:
 Написав на доске все числа от 1 до N, N = 50, преподаватель разделил числа на несколько групп
 так, что если одно число делится на другое, то эти числа попадают в разные руппы.
 В результате этого разбиения получилось M групп, для N = 50, M = 6
 N = 50
 Группы получились такими:

 Группа 1: 1
 Группа 2: 2 3 5 7 11 13 17 19 23 29 31 37 41 43 47
 Группа 3: 4 6 9 10 14 15 21 22 25 26 33 34 35 38 39 46 49
 Группа 4: 8 12 18 20 27 28 30 42 44 45 50
 Группа 5: 16 24 36 40
 Группа 6: 32 48

Задача: найти M при заданном N.
И получить разбиение на группы

int[] array = new int[50];

void FillArray(int[] fill)
{
    for (int row = 0; row < fill.Length; row++)
    {
        fill[row] = row + 1;
    }
}

void PrintArray(int[] print)
{
    for (int row = 0; row < print.Length; row++)
    {
        Console.Write(print[row] + " ");
    }
}


FillArray(array);
PrintArray(array);