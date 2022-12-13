void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]} ");
}

int FindCountOfNecessaryElements(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
        if (array[i].Length <= 3)
            count++;
    return count;
}

void FillNewArray(string[] array, string[] NewArray)
{   
    int j = 0;
    for (int i = 0; i < array.Length; i++)
            if (array[i].Length <= 3)
            {
                NewArray[j] = array[i];
                    j++;
            } 

}

void PrintNewArray(string[] NewArray)
{
    for (int i = 0; i < NewArray.Length; i++)
        Console.Write($"{NewArray[i]} ");
}

Console.WriteLine("Введите количество элементов исходного массива:");
int size = int.Parse(Console.ReadLine() ?? "0");
string[] array = new string[size];

for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i + 1}-й элемент исходного массива:");
    array[i] = Console.ReadLine() ?? "0";
}
Console.WriteLine("Исходный массив:");
PrintArray(array);
string[] NewArray = new string[FindCountOfNecessaryElements(array)];
FillNewArray(array, NewArray);
Console.WriteLine("");
Console.WriteLine("Новый массив:");
PrintNewArray(NewArray);