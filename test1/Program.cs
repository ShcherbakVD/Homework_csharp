int digit = 161;
int res1 = digit % 7;
int res2 = digit % 23;
if (res1 == 0)
{
    if (res2 == 0)
    {
        Console.WriteLine("Да");
    }
}
else
{
    Console.WriteLine("Нет");
}