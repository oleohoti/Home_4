// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.

// 452 -> 11

// 82 -> 10

// 9012 -> 12
Console.WriteLine("Input int num");
int num = Convert.ToInt32(Console.ReadLine());
void SumChisel(int num)
{
    int sum=0;
    while(num!=0)
    {
        sum=sum+num%10;
        num=num/10;
    }
    Console.WriteLine($"{sum}");
}
SumChisel(num);