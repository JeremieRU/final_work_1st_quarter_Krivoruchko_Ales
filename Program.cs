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

string[] incomingarray = Console.ReadLine()!.Split(' ');

int size = SizeOfOutputArrayIfLess4(incomingarray);

Console.Write(size);