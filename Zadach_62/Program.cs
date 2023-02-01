/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */
Console.Clear();
int[,] GetArraySpiral(int m= 4)
  {
    int num =2;
    int[,] result = new int[m, m];
    result [0,0]=1;
    int j=0, i=0;
    int schet=0;
    for(int k=1; schet<m*2; k++)
      {
        for(int count=0; count< 4 && schet<m*2; count++, schet++)
          {
           switch (count)
           {
            case 0:  
                while (j<m-k)
                  {
                    j+=1;
                    result[i, j] = num;
                    num++;
                  }

                break;
            case 1:  
                while (i<m-k)
                  {
                    i+=1;
                    result[i, j] = num;
                    num++;
                  }
;
                break;
            case 2:  
                while (j>k-1)
                  {
                    j-=1;
                    result[i, j] = num;
                    num++;
                  } 

                break;
            default:
                while (i>k)
                {
                  i-=1;
                  result[i, j] = num;
                  num++;
                } 

                break;
          }

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
            Console.Write($"{inArray[i,j]} \t");
          }
        Console.WriteLine();
      }
  }

    
int [,] array = GetArraySpiral();
   
PrintArrayInt(array);