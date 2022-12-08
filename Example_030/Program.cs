// Задача 30: - HARD необязательная Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.. Далее надо посчитать количество нулей и единиц, если единиц больше чем нулей то вывести TRUE на экран, иначе вывести False.
int[]rendr(int len)// Метод создания массива и вывода на экран элементов
{
    int[]array=new int[len];
    Random rnd = new Random();
    for(int i=0; i<len;i++){array[i] = rnd.Next(0,2);Console.WriteLine(array[i]);}
    return array;
}
void tf(int[]mas)// Метод вывода true|false
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
    Console.WriteLine(a);
}

int len =8; // ввод размера массива
int[]mas = rendr(len);// создание переменной массива для работы в методе tf

tf(mas);// вызов метода tf

