//Программа на вычисление большего числа
Console.WriteLine("Введите 1-е число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.WriteLine("Первое число больше второго");
}
if (numberB > numberA)
{
    Console.WriteLine("Второе число больше первого");
}
if (numberA == numberB)
{
    Console.WriteLine("Оба числа равны");
}