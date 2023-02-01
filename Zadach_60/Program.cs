/* Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */
Console.Clear();
int[,,] GetArray3(int m=4, int n=4, int k=4, int min=10, int max=15)
  {
    int[,,] result = new int[m, n, k];
    for (int i = 0; i < m; i++)
      {
        for (int j = 0; j < n; j++)
          {
            for (int l = 0; l < k; l++, min+=6, max+=6)
              {
                result[i, j , l] = new Random().Next(min, max + 1);
              }
          }
      }
return result;
}
    
void PrintArray3(int[,,] inArray)
  {
    for (int i = 0; i < inArray.GetLength(0); i++)
      {
        for (int j = 0; j < inArray.GetLength(1); j++)
          {
            for (int l = 0; l < inArray.GetLength(2); l++)
              {
                Console.Write("{0} ({1},{2},{3}) ",inArray[i,j,l], i, j, l);
              }
          }
        Console.WriteLine();
      }
  }
    
int [,,] array = GetArray3(2,2,2);
  
PrintArray3(array);
