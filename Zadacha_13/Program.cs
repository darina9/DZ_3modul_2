Console.WriteLine("Введите  число");
int num = Convert.ToInt32(Console.ReadLine());
if(num<100)
{
    Console.WriteLine("В этом числе нет третьей цифры");
}
else if(num>100 && num<1000)
{   
    int num1= num%10;
    Console.WriteLine("Третья цифра :" + num1);}

else if(num>1000 && num<10000)

{  
    int num2= (num%100)/10;
    Console.WriteLine("Третья цифра :" + num2);}

else if(num>10000 && num<100000)

{  
    int num3= (num%1000)/100;
    Console.WriteLine("Третья цифра :" + num3);}
