
Console.Write("Введите одно целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int[] fiblist = MadeFibList(num);
PrintArray(fiblist);

int[] MadeFibList(int num)
{

    int[] A = new int[num + 1];
    for (int i = 0; i <= num; i++) A[i] = Fibonachi(i);


    int[] ANFib = new int[num + 1];
    for (int i = 0; i <= num; i++) ANFib[i] = A[i];
    for (int i = 0; i <= num; i += 2) ANFib[i] = -ANFib[i];


    int[] AFib = new int[2 * num + 1];
    for (int i = 0; i < num; i++) AFib[i] = ANFib[num - i];
    for (int i = num + 1; i < AFib.Length; i++) AFib[i] = A[i - num];

    return AFib;
}

void PrintArray(int[] array)
{
    foreach (int el in array)
        Console.Write($"{el,2}\t");
    Console.WriteLine();
}

int Fibonachi(int n)
{
    if (n == 0 || n == 1) return n;

    return Fibonachi(n - 1) + Fibonachi(n - 2);
}