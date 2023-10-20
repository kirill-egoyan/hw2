System.Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if(day < 6)
{
    System.Console.Write("нет");
}
if(day > 5 && day < 8)
{
    System.Console.Write("да");
}
if(day > 7)
{
    System.Console.WriteLine("Не является днем недели");
}

