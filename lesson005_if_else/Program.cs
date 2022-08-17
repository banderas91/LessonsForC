Console.Write("Введите имя ");
string username = Console.ReadLine();

if(username.ToLower() == "маша") // переводит все буквы в консоли в нижний регистр
{
    Console.WriteLine("Ура! Это же Маша!");
}
else
{
    Console.Write("Привет ");
    Console.WriteLine(username);
}
