﻿// Сортировка выбором или мин макс
//1. Найти позицию минимального элемента в неотсортированной части массива
//2. Произвести обмен этого значения со значением первой неотсортированной позиции.
//3. Повторять пока есть не отсортррованные элементы.


int[] arr ={1,5,4,3,2,6, 7, 1, 1};

void PrintArray (int[] array) // метод вывода массива
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort (int[] array) // метод упорядочивания сортировки массива
{
for (int i =0; i < array.Length - 1; i++)
{
    int minPosition=i;
    for (int j = i +1; j <array.Length; j++)
    {
        if (array[j] < array[minPosition] ) minPosition = j;
    }




     int temporarry = array[i];
     array[i]= array[minPosition];
     array[minPosition] = temporarry;

}
}
PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);