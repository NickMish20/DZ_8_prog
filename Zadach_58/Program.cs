/* Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18 */
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

void MultArray(int [,] arr1, int [,] arr2)
  { 
    int m1= arr1.GetLength(0), n1= arr1.GetLength(1);
    int m2= arr2.GetLength(0), n2= arr2.GetLength(1);
    if (n1!=m2)
      {
        Console.WriteLine("Массивы не возможно перемножить!"); 
      }
    else
      {
        int [,] arr3 = new int [m1,n2];
        for(int i=0; i<m1; i++)
          {
              
              for(int j=0; j<n2; j++)
                {
                  for(int k=0; k<n1; k++)
                    {
                      arr3[i,j]+= arr1[i,k]*arr2[k,j];
                    }
                }
          }
        PrintArrayInt(arr3);
      }
  }
    
int [,] array1 = GetArrayInt(2,2,0,10);
int [,] array2 = GetArrayInt(2,2,0,10);    
PrintArrayInt(array1);
Console.WriteLine(); 
PrintArrayInt(array2);    
Console.WriteLine();    
MultArray(array1,array2);
