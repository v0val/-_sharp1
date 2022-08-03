Console.WriteLine("Введите Ваше имя");
string nameUser = Console.ReadLine();
if (nameUser.ToLower() == "маша")
{
    Console.WriteLine("Ура, это же Маша!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(nameUser);
}