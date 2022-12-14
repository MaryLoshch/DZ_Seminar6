void FillArray(int[] _num)
{
    for (int i = 0; i < _num.Length; i++)
    {
        int a;
        Console.Write($"Введите элемент [{i}]: ");
        int.TryParse(Console.ReadLine()!, out a);
        _num[i] = a;
    }
}
void PrintArray(int[] _num)
{
    for (int i = 0; i < _num.Length; i++)
    {
        Console.Write(_num[i] + " ");
    }
    Console.WriteLine();
}

Console.Clear();
int size;
Console.WriteLine("Введите количество чисел М: ");
int.TryParse(Console.ReadLine()!, out size);

int[] num = new int[size];
FillArray(num);
PrintArray(num);
int count = 0;

for (int i = 0; i < num.Length; i++)
    if (num[i] > 0)
        count++;

Console.WriteLine($"В массиве {num.Length} чисел, чисел больше нуля: {count}");