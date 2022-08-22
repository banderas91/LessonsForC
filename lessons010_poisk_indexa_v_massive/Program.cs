
int[] array = {1, 42, 23, 41, 8, 16, 27, 18};

int n = array.Length; // возвращает количество элементов в массиве
int find = 18;
int index = 0;

while (index < n)
{

    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;

}