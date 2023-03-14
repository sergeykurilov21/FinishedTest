string[] arr = {"hello", "2", "world", ":-)" , "123", "slo"};
string[] array = new string[arr.Length];




void CalculateArray (string[] arr,string[] array)
{
    int count = 0;

    for ( int i = 0 ; i < arr.Length; i ++)
    {
        if (arr[i].Length<=3 )
        {
            array[count] = arr[i];
            count++;
            Console.Write(array[count]);
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
CalculateArray(arr, array);

Console.Write("Итоговый массив: ");
PrintArray(array);