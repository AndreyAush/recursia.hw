
void PrintReserveArray (int[] array, int j)
{
    if (j == 0)
    {
        Console.Write(array[j]);
       return;
    }
    //рекурсивный случай
    Console.Write(array[j] + " ");
    PrintReserveArray(array, j - 1);
}
int[] array = { 1, 2, 3, 4 };
int j = array.Length - 1; 
PrintReserveArray(array, j);
