void FillArray(int[] collection) // метод заполнения массива рандомно

{
    int length = collection.Length;
    Int16 index = 0;
    while (index < length)
    {

        collection[index] = new Random().Next(1, 10);
        index++;
    }

}

void PrintArray(int[] col) // метод печати массива
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Indexof(int[] collection, int find) // поиск номера позиции элемента
{
    int count = collection.Length;
    int index = 0;
    int position = -1; // если в массиве не существует элемента который мы ищем, то выведится -1
    while (index < count)
    {
            if(collection[index] == find)
            {
                position = index;
                break;
            }
            index++;
    }
    return position;
}


int[] array = new int [10]; // создаем массив содержащий 10 элементов

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = Indexof(array, 444); // задаем элемент который необходимо найти
Console.WriteLine(pos); // выводим позацию элемента