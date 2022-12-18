Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if (username.ToLower() == "катя")
{
    Console.WriteLine("Ура!!! Катюха!!!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}