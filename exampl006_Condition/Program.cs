Console.Write("Введите имя ползователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "Ангелина")
{
    Console.WriteLine("Ура, это же Ангелина ");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}