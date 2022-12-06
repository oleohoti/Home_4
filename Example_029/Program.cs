// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.
int [] array = new int[8];
void InputArray(int[]array)
{
    for(int i=0; i<array.Length;i++)
    {
    Console.WriteLine($"Введите {i+1} элемент массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Массив :");
    for (int i = 0; i < array.Length; i++) Console.Write($" {array[i]} ");

}
InputArray(array);