Console.WriteLine("Введите трехзначное число");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = (num1/10)%10;
Console.WriteLine($"Второе число - {num2}");