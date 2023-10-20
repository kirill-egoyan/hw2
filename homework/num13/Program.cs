int ShowThirdDigit(int num)
{
    if(num < 100)
    {
        System.Console.WriteLine("третьей цифры нет");
    }
    if(num < 999 && num > 99)
    {
        num = num % 10;
    }
    if(num > 999)
    {
        while(num > 999)
        {
            num = num / 10;
        }
         num = num % 10; 
    }
    return num;
}


System.Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine(ShowThirdDigit(num));

