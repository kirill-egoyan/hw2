int ShowSecondDigit(int num)
{
    int des = num /10 % 10;
    
    return des;
}
System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(ShowSecondDigit(num));

