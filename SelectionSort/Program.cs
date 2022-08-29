int[] array = new int[] { 8, 5, 2, 9, 5, 6, 3 };
int[] result = SelectionSort(array);
foreach (var item in result)
{
    Console.Write(" " + item);
}
Console.ReadKey();

int[] SelectionSort(int[] array)
{

    for (int i = 0; i < array.Length - 1; i++)
    {
        int smallIdx = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[smallIdx] > array[j])
            {
                smallIdx = j;
            }
        }
        swap(i, smallIdx, array);

    }
    return array;
}

void swap(int i, int j, int[] array)
{
    int temp = array[j];
    array[j] = array[i];
    array[i] = temp;
}
