// Напишите программу, которая помещает цифры произвольного числа в целочисленный массив (массив заполнять начиная с младшего разряда числа) 
// Полученный массив вывести на экран.

// 1. Получаем число
int num = Convert.ToInt32(Console.ReadLine());


// 2. Получаем длину массива
// 2.1 1 вариант
int countOfDigits = 0;
int tmp = num;
while(num != 0)
{
    num = num /10;
    countOfDigits++;
}

// 2.2 2 вариант

//countOfDigits =  num.ToString.Length;

// 3. создаем масси с определенным размером

int [] digits; 
digits = new int [countOfDigits];

// 4. Поместить цифры в массив
int i = 0;
tmp = num;
while(num != 0)
{
    digits[i] = tmp% 10;
    tmp = tmp  /10;
    countOfDigits++;
    i++
}

5. вывод на экран