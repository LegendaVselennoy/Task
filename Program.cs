// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] first_matrix=FillMas(2,2);
int[,] second_matrix=FillMas(2,2);
int[,] array2=FillMas(4,4);
int[,] array=FillMas(3,4);
PrintArray(array);
Console.WriteLine();
MixingStringNumbers(array);
PrintArray(array);

int[,] FillMas(int n, int m)
{
    
    int[,] mas = new int[n, m];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            mas[i, j] =new Random().Next(1,5);
        }
    }
    return mas;
}


void PrintArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j != arr.GetLength(1) - 1) Console.Write($"{arr[i, j]}, ");
            else if (i == arr.GetLength(0) - 1 && j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]}");
            else if (j == arr.GetLength(1) - 1) Console.WriteLine($"{arr[i, j]},");
        }
    }
}

// Решение 1

void MixingStringNumbers(int[,] array)
{ 
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int k =0; k < array.GetLength(1)-1; k++)
         {
            int max=k+1;
            if(array[i,k]<array[i,max])
            {
              int temporary=array[i,k];
              array[i,k]=array[i,max];
              array[i,max]=temporary;  
            }
         }
      }
   }
}


////////////////////////////////////////////////////////////////////////////////

// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Решение 2

PrintArray(array2);
TheSumOfTheElementsInEachRow(array2);

void TheSumOfTheElementsInEachRow(int[,] arr2)
{
    int sum1 = 0; 
    int count = 0; 
    int sum2 = 0;
    for (int i = 0; i < arr2.GetLength(1); i++)
    {
        sum1 += arr2[0, i];
    }
    for (int i = 0; i < arr2.GetLength(0); i++)
    {
        for (int j = 0; j < arr2.GetLength(1); j++) 
        sum2 += arr2[i, j];
        if (sum2 < sum1)
        {
            sum1 = sum2;
            count = i;
        }
        sum2 = 0;
    }
    Console.WriteLine();
    Console.WriteLine($"{count + 1} строка");
}

// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
//Каждый элемент строки одной матрицы умножаем на столбец другой матрицы. Результат суммируется.

// Решение 3

Console.WriteLine("Первая матрица");
PrintArray(first_matrix);
Console.WriteLine("Вторая матрица");
PrintArray(second_matrix);
Console.WriteLine("Результирующая матрица");
int[,] third=GeneralMatrix(first_matrix,second_matrix);
PrintArray(third);

int[,] GeneralMatrix(int[,] one,int[,] two)
{
   int[,] composition=new int [2,2];
   composition[0,0]=one[0,0]*two[0,0]+one[0,1]*two[1,0];
   composition[0,1]=one[0,0]*two[0,1]+one[0,1]*two[1,1];
   composition[1,0]=one[1,0]*two[0,1]+one[1,1]*two[1,0];
   composition[1,1]=one[1,0]*two[0,1]+one[1,1]*two[1,1];
   return composition;
}

// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

//Решение 4

int[,,] dimensional_array=FillMasArray();
PrintArrayMas(dimensional_array);

int[,,] FillMasArray(){
    int[,,] mas = new int[2,2,2];
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            for (int k = 0; k < mas.GetLength(2); k++)
            {
                mas[i, j,k] =new Random().Next(1,100);
            }
        }      
    }
    return mas;
}
   
void PrintArrayMas(int[,,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            { 
               Console.Write(arr[i,j,k]+""+(i,j,k)+" "); 
            }
            Console.WriteLine();
        }      
    } 
}

// Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Решение 5

int[,] spiralArray=FillArraySpiral(4,4);
PrintArray(spiralArray);

void PrintArray(int[,] arr){
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j]+" ");  
        } 
       Console.WriteLine();      
    } 
}

int[,] FillArraySpiral(int lines, int columns){
    int[,] mas = new int[lines,columns];
    int a=1;
    int count=0;
    for (int i = 0,j=0; i < lines;i++)
    {
       mas[j,i]=a+count++;
    }
    for (int i = 0,j=columns-1; i < columns; i++)
    {
        mas[i,j]=count++;
    }
    for (int i =2; i >0; i--)
    {
        mas[lines-1,i]=count++;
    }
    for (int i=columns-1,j=0; i >0; i--)
    {
        mas[i,j]=count++;
    }
    for (int i = 1,j=1; i < lines-1; i++)
    {
        mas[j,i]=count++;
    }
    for (int i = 2,j=2; j>0; j--)
    {
        mas[i,j]=count++;
    }
    return mas;
}
// Позже думаю переделать методы.