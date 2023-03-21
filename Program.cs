int SizeOfOutputArrayIfLess4(string[] arr)
{
    int size = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            size++;
        }
    }
    return size;
}

void FillOutputArray(string[] arr1, string[] arr2)
{
    int l = 0;
    int s = 0;
    while (l < arr1.Length)
    {
        if (arr1[l].Length <= 3)
        {
            arr2[s] = arr1[l];
            s++;
        }
        l++;
    }
}

void PrintArray(string[] arr)
{
    Console.Write("[");
    for (int j = 0; j < arr.Length - 1; j++)
    {
        Console.Write($"{arr[j]}, ");
    }
    Console.Write($"{arr[arr.Length - 1]}]");
}

Console.WriteLine("Введите данные через пробел: ");
string[] incomingarray = Console.ReadLine()!.Split(' ');

int size = SizeOfOutputArrayIfLess4(incomingarray);

if (size == 0)
    size = 1;

string[] outputarray = new string[size];

FillOutputArray(incomingarray, outputarray);

PrintArray(incomingarray);
Console.Write(" -> ");
PrintArray(outputarray);