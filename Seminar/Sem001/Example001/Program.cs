Console.WriteLine("Введите 1-е число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int numB = Convert.ToInt32(Console.ReadLine());

if (numB == numA * numA)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}