Console.WriteLine("Start");
int j = 0;
string[] Array = {"Une", "orange", "sur", "la", "table", "Ta", "robe", "sur", "le", "tapis", "Et", "toi", "dans", "mon", "lit"};
string[] Array2 = new string[Array.Length];
for (int i = 0; i < Array.Length; i++)
{
    if (Array[i].Length <= 3)
    {
        Array2[j] = Array[i];
        j += 1;
    }
}

printArray(Array2);

void printArray(string[] arr)
{
    foreach (var item in arr)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}