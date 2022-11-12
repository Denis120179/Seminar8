// Задача 54 Задайте двумерный массив
// Напишите программу, которая упорядочит по убыванию элементы каждой строки
/*
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

SortMaxMin(array);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{ 
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]}  ");            
        }
        Console.WriteLine();
    }
}

void SortMaxMin(int[,] Array)
{
    for (int n = 0; n < Array.GetLength(1); n++)
    {   
        for (int i = 0; i < Array.GetLength(0); i++)
        {
            int min = Array[i,n];
            for(int j = 0; j < Array.GetLength(1); j++)
            {
                if(Array[i,j] < min) 
                {
                    min = Array[i,j];  
                    Array[i,j] = Array[i,n];
                    Array[i,n] = min;                                                                       
                }                                                     
            }                                     
        }       
    }
}
*/

// Задача 56
// Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов
/*
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
MinSum(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{ 
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]}  ");            
        }
        Console.WriteLine();
    }
}

void MinSum(int[,] Array)
{       
    int [] res = new int[Array.GetLength(0)]; // массив для хранения сумм
    for (int i = 0; i < Array.GetLength(0); i++)
    {         
        int sum = 0;      
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            sum = sum + Array[i,j];            
        } 
        res[i] = sum;          
        Console.WriteLine($"{sum}"); // Строка необязательная, скорее для наглядности, чтобы не считать сумму элементов         
    }    
    int index = 0;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        if (res[i] < res[index]) index = i;                               
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов:  {index} строка");             
}
*/

// Задача 58
// Задайте две квадратные матрицы.
// Напишите программу, которая будет находить произведение двух матриц
/*
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array1 = GetArray(rows, columns, 0, 10);
PrintArray(array1);
Console.WriteLine();

int[,] array2 = GetArray(rows, columns, 0, 10);
PrintArray(array2);
Console.WriteLine();

int[,] array3 = MultiMatrix(array1, array2);
PrintArray(array3);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{ 
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]}  ");            
        }
        Console.WriteLine();
    }
}

int[,] MultiMatrix(int[,] matrix1, int[,] matrix2)
{
    int [,] res = new int[matrix1.GetLength(0),matrix1.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {   
        for(int j = 0; j < matrix1.GetLength(1); j++)
        {
            for(int n = 0; n < matrix1.GetLength(0); n++)
            {
                res[i,j] = res[i,j] + matrix1[i,n]*matrix2[n,j];            
            }
        }           
    }
    return res;
}
*/

// Задача 60
// Сформируйте трехмерный массив из неповторяющихся двухначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента. Массив размером 2*2*2
/*
Console.WriteLine("Введите длину массива: ");
int x = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите ширину массива: ");
int y = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите глубину массива : ");
int z = int.Parse(Console.ReadLine()!);

int[, ,] array = GetArray(x, y, z, 10, 99);
PrintArray(array);

int[, ,] GetArray(int a, int b, int c, int minValue, int maxValue)
{ 
    int[, ,] result = new int[a,b,c];
    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            for(int k = 0; k < c; k++)
            {
                int number = new Random().Next(minValue, maxValue + 1);
                if(SameNumber(result, number)) continue;                 
                result[i,j,k] = number;                
            }
        }         
    }
    return result;
} 

void PrintArray(int[, ,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            for(int k = 0; k < Array.GetLength(2); k++)
            {
                Console.Write($"{Array[i,j,k]} ({i}, {j}, {k}) ");            
            }
            Console.WriteLine();
        }
        Console.WriteLine();
    }
}

bool SameNumber(int[ , ,] Array, int n)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            for(int k = 0; k < Array.GetLength(2); k++)
            {
                if(Array[i,j,k] == n) return true;            
            }            
        }        
    }
    return false;
}
*/

// Рекомендованная задача
// Отсортировать нечетные столбцы массива по возрастанию, и вывести массив изначальный и отсортированный
/*
Console.WriteLine("Введите количество строк: ");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int columns = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
Console.WriteLine();

SortMinMax(array);
PrintArray(array);

int[,] GetArray(int m, int n, int minValue, int maxValue)
{ 
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for(int j = 0; j < Array.GetLength(1); j++)
        {
            Console.Write($"{Array[i,j]}  ");            
        }
        Console.WriteLine();
    }
}

void SortMinMax(int[,] Array)
{
    for (int n = 0; n < Array.GetLength(0); n++)
    {   
        for (int j = 1; j < Array.GetLength(1); j+=2)
        {
            int max = Array[n,j];
            for(int i = 0; i < Array.GetLength(0); i++)
            {
                if(Array[i,j] > max) 
                {
                    max = Array[i,j];  
                    Array[i,j] = Array[n,j];
                    Array[n,j] = max;                                                                       
                }                                                     
            }                                     
        }       
    }
}
*/