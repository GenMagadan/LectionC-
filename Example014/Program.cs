﻿int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 5 };

void PrintArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
   {
      Console.Write($"{array[i]}, ");
   }
   Console.WriteLine();
}

void SelectionSort(int[] array)
{
   for (int i = 0; i < array.Length - 1; i++)
   {
      int minPos = i;
      for (int j = i + 1; j < array.Length; j++)
      {
         if (array[j] < array[minPos])
         {
            minPos = j;
         }
      }
      int temp = array[i];
      array[i] = array[minPos];
      array[minPos] = temp;
   }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);