/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка */
Console.Clear();
int[,] GetArrayInt(int m=4, int n=4, int min=0, int max=10)
  {
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
          {
            result[i, j] = new Random().Next(min, max + 1);
          }
      }
return result;
}
    
void PrintArrayInt(int[,] inArray)
  {
    for (int i = 0; i < inArray.GetLength(0); i++)
      {
        for (int j = 0; j < inArray.GetLength(1); j++)
          {
            Console.Write($"{inArray[i,j]} ");
          }
        Console.WriteLine();
      }
  }

void GetArrayMinSum(int [,] arr)
  { 
    int m= arr.GetLength(0), n= arr.GetLength(1);
    int [] sumArr = new int [m];
    for(int i=0; i<m; i++)
      {
          int sum=0;
          for(int j=0; j<n; j++)
            {
              sum+=arr[i,j];
            }
        sumArr[i] = sum;
      }
  int p=0;
  for(int k=0; k<m-1; k++)
    {
        
      if(sumArr[p]>sumArr[k+1])
        {
          p=k+1;
        }
    }
   Console.WriteLine("Строка с наименьшей суммой это строка {0}", p); 
  }
    
int [,] array = GetArrayInt();
PrintArrayInt(array);

Console.WriteLine();    
GetArrayMinSum(array); 