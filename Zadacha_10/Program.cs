Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(Console.ReadLine());
int num1=num%100;
int num2=num1/10;
Console.WriteLine("Вторая цифра числа : " + num2);