int n = 75;
int firstDigit = n / 10;
int secondDigit = n % 10;
if (firstDigit > secondDigit)
{
    Console.WriteLine(firstDigit);
}
else
{
    Console.WriteLine(secondDigit);
}
