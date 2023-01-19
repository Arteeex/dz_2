Console.Clear();

int a = Convert.ToInt32(Console.ReadLine());

if (a < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else if (a < 1000)
{
    int result_1 = a %10;
    Console.WriteLine(result_1);   
}
else if (a > 9999)
{
    int result_2 = (a % 11);
    Console.WriteLine(result_2);  
}
else
{
int result = (a / 10) % 10;
Console.WriteLine(result);
}