int Reverse(int value)
{
    int result = 0;
    while (value != 0)
    {
        result = result * 10 + value % 10;
        value /= 10;
    }
    return result;
}

int Length(int value)
{
    int result = 0;
    while (value != 0)
    {
        result ++;
        value /= 10;
    }
    return result;
}


void Palindrom(int value)
{
    while (Length(value) > 1)
    {
        if (value % 10 == Reverse(value) % 10 && value >= 0)
        {
            value /= 10;
            value = Reverse(value) / 10;  
            if ((Length(value) == 2 && value / 10 == value % 10) || (Length(value) == 1))
            {
                Console.WriteLine("Является палиндромом");
                return;
            }
        }
        else
        {
            Console.WriteLine("Не является палиндромом");
            return;
        }
    }
}

int a;
Console.WriteLine("Введите число");
a = Convert.ToInt32(Console.ReadLine());
Palindrom(Math.Abs(a));





