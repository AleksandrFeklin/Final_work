string[] array1 = new string[6] { "222", "`223", "-2222", "-d899", "ads", "33" };
string[] array2 = new string[array1.Length];
void NewArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[count] = array1[i];
            count++;
        }
    }
}
void ViewArr(string[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length - 1)
        {
            result += array[i] + ", ";
        }
        if (i == array.Length - 1)
        {
            result += array[i] + "]";
        }
    }
    Console.Write("Исходный массив : ");
    Console.WriteLine(result);
}
void PrintArray(string[] array)
{
    string result = "[";
    for (int i = 0; i < array.Length; i++)
    {
        if (i < array.Length -3)
        {
            result += array[i] + ", ";
        }
        if (i == array.Length -3)
        {
            result += array[i] + "]";
        }
    }
    Console.Write("Готовый массив : ");
    Console.WriteLine(result);
}
ViewArr(array1);
Console.WriteLine();
NewArray(array1, array2);
PrintArray(array2);

