// See https://aka.ms/new-console-template for more information

int[] arr = Enumerable.Range(1,10).ToArray();
Console.WriteLine(calculateAvg(arr));

static double calculateAvg(int[] arr)
{
    int sum = 0;
    foreach (var num in arr)
    {
        sum += num;
    }

    return (double)sum / arr.Length;
}