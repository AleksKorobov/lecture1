// Особенное приветствие пользователя
Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();

if (username.ToLower() == "маша")//ToLower() -  позволяет все буквы имени пользователя переводить в маленькие и при любом неправильном написани имени МАШа, условие будет работать
{
    Console.WriteLine ("Ура, это же МАША!");
}
else
{
    Console.Write ("Привет, ");
    Console.Write (username);
    Console.WriteLine ("!");
}