/* Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2 */
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

void GetArrayMaxMin(int [,] arr)
  { 
    int m= arr.GetLength(0), n= arr.GetLength(1);
    int num=0;
    for(int i=0; i<m; i++)
      {
          for(int j=0; j<n; j++)
            {
              for(int k=n-1; k>j; k--)
                {
                  if(arr[i,k]>arr[i,k-1])
                    {
                      num=arr[i,k-1];
                      arr[i,k-1]=arr[i,k];
                      arr[i,k]=num;
                    }
                  
                }
            }
      }
    PrintArrayInt(arr);
  }
int [,] array = GetArrayInt();
PrintArrayInt(array);

Console.WriteLine();    
GetArrayMaxMin(array);
