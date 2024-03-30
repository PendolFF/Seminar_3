int[] array = new int[7];
int[] array1 = new int[array.Length / 2];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + "\t");
}

Console.WriteLine();
for (int i = 0; i < array.Length / 2; i++)
{
    array1[i] = array[i] * array[array.Length - 1 - i];
    Console.Write(array1[i] + "\t");
}
