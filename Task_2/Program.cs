//создание массива из случайных числе утсановленного размера и диапазона элементов
int[] array = new int [10];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(-10,10);
    Console.Write(array[i]+ "\t");
}
 Console.WriteLine();

for (int i = 0; i < array.Length; i++)
{
    array[i] =-1 * array[i];
    Console.Write(array[i]+ "\t");
}
