//Напишите программу, которая выводит случайное число из отрезка (10, 99) и показывает наибольшую цифру этого числа.
// 1. Диапазон задается
int start = 10;
int stop = 99;

//2. Сгенерировать случайное число
int value = new Random().Next(start, stop + 1);
Console.WriteLine(value);

//3. Извлечение чифр из числа 
int digit_first = value / 10;
int digit_second = value % 10;

//4. сравнение чисел

//5. вывод числа

//a.ToString() // перевод числа в строку
