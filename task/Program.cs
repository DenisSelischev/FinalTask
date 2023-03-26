Console.Write("Введите количество элементов: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] FillArrey = new string[size];
for (int i = 0; i < size; i++)
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string ?element = Convert.ToString(Console.ReadLine());
    FillArrey[i] = element;
}

string[] SelectionArrey = new string[size];
int num = 3;
int pos = 0;

for (int j = 0; j < size; j++)
{
    if (FillArrey[j].Length <= num)
    {
        SelectionArrey[pos] = FillArrey[j];
        pos++;
    }
}

Console.WriteLine();
PrintArray(SelectionArrey);

void PrintArray(string[] array)
{
    for (int k = 0; k < array.Length; k++)
    {
        Console.Write(array[k] + " ");
    }
    Console.WriteLine();
}