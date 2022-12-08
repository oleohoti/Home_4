// Задача 26. - HARD необязательная Напишите программу, которая принимает на вход целое или дробное число и выдаёт количество цифр в числе.

// 452 -> 3

// 82 -> 2

// 9,012 ->4

void Operation ()
{
Console.WriteLine("Введите число любой разрядности");
string cw = String.Empty;
double num = Convert.ToDouble(Console.ReadLine());    
decimal dec = Convert.ToDecimal(num);
int num1=Convert.ToInt32(num);
int count =0;
while(dec!=0) {dec=dec*10%10;count++;}
if (num1!=0) {count--;}
else cw = " *с учетом цифры 0 перед запятой. ";
while(num1!=0) {num1=num1/10;count++;}
Console.WriteLine($"Всего цифр: {count}.{cw}");
}
Operation();
