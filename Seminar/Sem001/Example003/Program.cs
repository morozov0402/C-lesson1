//задача на промежутки
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = a - (a * 2);
int c = b;

while (c <= a)
{
    Console.Write(c + ", ");
    c++;
}