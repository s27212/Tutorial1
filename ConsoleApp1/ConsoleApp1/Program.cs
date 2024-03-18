// See https://aka.ms/new-console-template for more information

int[] arr = Enumerable.Range(1,10).ToArray();
Console.WriteLine(calculateAvg(arr));
Console.WriteLine(max(arr));

static double calculateAvg(int[] arr)
{
    int sum = 0;
    foreach (var num in arr)
    {
        sum += num;
    }

    return (double)sum / arr.Length;
}

static int max(int[] arr)
{
    int max = Int32.MinValue;
    foreach (var i in arr)
    {
        if (i > max) max = i;
    }

    return max;
}