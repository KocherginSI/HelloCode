int count = 0;
Console.Write("Введите Имя: ");
string user_name = Console.ReadLine();

if(user_name.ToLower() == "павел")
{
    count += 1;
    Console.Write("Здравствуйте, ");
    Console.Write(user_name);
    Console.WriteLine("!");
    Console.Write(count);
}
else
{
    Console.Write("Здравствуйте, ");
    Console.Write(user_name);
    Console.Write("! Вы знаете Павла?");
 }