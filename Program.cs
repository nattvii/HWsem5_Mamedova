// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void Input_array(int [] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 10);
}

void release(int[] array)
{
    int count = 0;
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
        if (i % 2 == 1)
        sum += array[i];
    else
         count ++;

    Console.WriteLine($"+{sum}");
        
}

Console.Clear();
Console.Write("Fill in a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
release(array);
