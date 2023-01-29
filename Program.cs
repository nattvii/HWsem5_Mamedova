// Задайте массив чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void Input_array(int [] array)
{
 {
    for (int i = 0; i < array.Length; i++)
    array[i] = new Random().Next(1, 15);
 }
}
void release(int[] array)
 {
    int min = 0;
    int max = 0;
    for (int i = 0; i < array.Length; i++)
 {
        if (array[i] < min)
           min = array[i];  

         if (array[i] > max)
            max = array[i];
      
 }
        

    Console.WriteLine($"Min element: {min}");
    Console.WriteLine($"Max element: {max}");
    int difference = max - min;
    Console.WriteLine($"A difference between max and min: {difference}");
 }


Console.Clear();
Console.Write("Fill in a number of elements: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Input_array(array);
Console.WriteLine($"[{string.Join(", ", array)}]");
release(array);
