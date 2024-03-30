int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int [size];
int userNum = Convert.ToInt32(Console.ReadLine());
string Print = "Нет";

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1,20);
    Console.Write(array[i]+ " ");
}

for (int i = 0; i < array.Length; i++)
{
    if (userNum == array[i])
    {
        Print = "Да";
    }
       
}
Console.WriteLine(Print);