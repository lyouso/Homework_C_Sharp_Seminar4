int[] array = new int[8];
Generate(array);
Print(array);
Sort(array);
Print(array);

void Generate(int[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rand.Next(-100, 100);
    }
}
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
void Sort(int[] array)
{
    int change = 0;
    int min = 0;
    for (int i = 0; i < (array.Length - 1); i++)
    {
        min = i;
        for (int j = i; j < array.Length; j++)
        {
            if (Math.Abs(array[j]) < (Math.Abs(array[min]))) min = j;
        }
        if (min != i)
        {
            change = array[i];
            array[i] = array[min];
            array[min] = change;
        }
    }
}
