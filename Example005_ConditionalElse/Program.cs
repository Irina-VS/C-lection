Console.WriteLine("Введите имя пользователя");
string username = Console.ReadLine();

if(username.ToLower() == "пончик") 
{
    Console.WriteLine ("Ура, Пончик пришел!!!");
}
else
{
    Console.WriteLine ("Привет, ");
    Console.WriteLine (username);
}
