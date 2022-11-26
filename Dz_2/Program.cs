Console.WriteLine("Введите число");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = 1;
if (num1<100)
{
   Console.WriteLine("Третьего числа нет"); 
}
else
{
    while (num1>1000)
    {
    num1 = num1/10;
    num2 = num1 % 10;
    }
    Console.WriteLine($"Третье число - {num2}");
}
