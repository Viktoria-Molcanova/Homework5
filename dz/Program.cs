static class Lesson456
{
    static void Main()
    {
    //Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
    //Создание массива
    Console.WriteLine("Введите размер массива  ");
    int size = Convert.ToInt32(Console.ReadLine());

    //Определение границ массива

    void FillArrayRandomNumbers(int[] array)
        {
        for(int i = 0; i < array.Length; i++)
            {
                array[i] = new Random().Next(1,100);
            }
        }

    //Заполнение массива случайными числами

    int[] array = new int[size];
    FillArrayRandomNumbers(array);
    Console.WriteLine("массив: ");
    
    //Печать массива

    PrintArray(array);
    int sum = 0;

    //Определение чётности чисел в массиве
    //Определение суммы чётных чисел массива

    for (int i = 0; i < array.Length; i+=2)
    sum = sum + array[i];

    //Печать результата вычислений

    Console.WriteLine($"{array.Length} числа в массиве, сумма нечётных чисел = {sum}");

    void PrintArray(int[] array)
    {
    Console.Write("[ ");
    for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
      Console.Write("]");
      Console.WriteLine();
    }
}}
