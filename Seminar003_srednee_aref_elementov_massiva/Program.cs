//1 создаем массив
int N = Convert.ToInt32(Console.ReadLine());
int [] array = new int [N];

// 2. заполняем случайныими числами

int index = 0;
while(index <N)
{
    array[index] = new Random().Next(1, 11); 
    Console.Write(array[index]+ "   ");
    index++;
}

// 3. Среднее арефметическое элементов массива
int sum = 0;
for(int i=0; i < N; i++)
{
    sum += array[i];
}
double mean = (double)sum / N;
Console.WriteLine(mean);