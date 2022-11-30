Console.Write("Введите имя: ");
string username = Console.ReadLine() ??"";
if (username.ToLower() == "maria")
{
    Console.WriteLine("Ура, это Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}