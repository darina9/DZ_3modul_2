Console.WriteLine("Введите цифру, обозначающую день недели");
int num = Convert.ToInt32(Console.ReadLine());
if(num==6 ||num==7 )
{
    Console.WriteLine("Это выходной!!!");
}
else if(num>7)
{
    Console.WriteLine("Это не день недели!!!");

}
else if(num>=1 && num <=5 )
{
    Console.WriteLine("Это будний день :(");}