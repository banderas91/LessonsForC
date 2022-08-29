// // // вид 1
// // void Method1()
// // {
// //     Console.WriteLine("автор...."); // Указание автора
// // }

// // //Method1(); // вызов метода






// // //вид 2 Не возвращаемые методы

// // void Method2( string msg)
// // {
// //     Console.WriteLine(msg);

// // }
// // //Method2(msg: "текс сообщения"); 

// // // вид 3 Методы не принимающие аргументы, но выводящие

// // int Method3()
// // {
// //     return DateTime.Now.Year;
// // }
// // // int  year = Method3();
// // // Console.WriteLine(year);

// // // вид 4 Методы принимающие и возвращающие

//  string Method4(int count, string text )
// { 
//     int i = 0;
//     string result = String.Empty;
    
//     while (i < count)
//     {
//         result = result + text;
//         i++;

//     }
//     return result;
// }

// string res = Method4(10, "wdewcrvw");
// Console.WriteLine(res);


// таблица умножения

for (int i = 2; i <= 10; i++)
{
    for (int j = 0; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j}= {i * j}");
    }
    Console.WriteLine();
}