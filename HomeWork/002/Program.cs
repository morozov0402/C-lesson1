//Программа на вычисление большего числа
Console.WriteLine("Введите 1-е число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 2-е число");
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите 3-е число");
int number3 = Convert.ToInt32(Console.ReadLine());
int maxNum = 0;

if (number1 > number2)
{
    maxNum = number1;
}
else
{
    maxNum = number2;
}

if (number3 > maxNum)
{
    maxNum = number3;
}

Console.WriteLine("Большее из введеных чисел " + maxNum);