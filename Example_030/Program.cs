// Задача 30: - HARD необязательная Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.. Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.
int[]rendr(int len)
{
    int[]array=new int[len];
    Random rnd = new Random();
    for(int i=0; i<len;i++){array[i] = rnd.Next(0,2);}
    return array;
}
bool tf(int[]mas)
{
    bool a = true;
    int zero = 0;
    int one = 0;
    for (int i = 0; i < mas.Length; i++)
    {
        if(mas[i]==1) one++;
        else zero++;
    }
    if (one>zero) a=true;
    else a=false;
    return a;
}

int len =8;
int[]mas = rendr(len);
for (int i = 0; i < mas.Length; i++)
{
    Console.WriteLine(mas[i]);
}
bool input = tf(mas);
Console.WriteLine(input);
