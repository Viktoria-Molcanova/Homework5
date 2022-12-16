static class Lesson456
{
    static void Main()
    {
     //Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
    
    //Создание массива

    Console.WriteLine("Введите размер массива");
    int size = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[size];
    FillArrayRandomNumbers(array);
    Console.WriteLine("Массив: ");

    //Определение границ массива

    void FillArrayRandomNumbers(double[] array)
    {
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
        }
    }

  //Печать массива

    PrintArray(array);
    double min = Int32.MaxValue;
    double max = Int32.MinValue;
    //Нахождение максимального и минимального числа в массиве

    for (int a = 0; a < array.Length; a++)
    {
    if (array[a] > max)
        {
            max = array[a];
        }
    if (array[a] < min)
        {
            min = array[a];
        }
      }

      //Печать максимального и минимального чисел в массиве и их разницу

    Console.WriteLine($"Массив {array.Length}. Максимальное число = {max}, минимальное число = {min}");
    Console.WriteLine($"Разница  = {max - min}");

    
    void PrintArray(double[] array)
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
