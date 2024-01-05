long n = 1;
if (n < 10)
{
    Console.Write(n);
}
else
{
    while (n >= 1)
    {
        long i = n % 10;
        Console.Write(i);
        Console.Write(',');
        n = n / 10;
    }
}