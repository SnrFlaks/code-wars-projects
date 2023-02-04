using System.Numerics;

int max = Int32.MaxValue;
BigInteger s;
BigInteger[] arr = new BigInteger[100];
long i = 2;
arr[i - 2] = 1;
arr[i - 1] = 2;
s = 0;
for (i = 2; arr[i - 1] < max; i++)
{
    if (arr[i] > max) break;
    else arr[i] = arr[i - 1] + arr[i - 2];
}
for (long f = 0; f <= arr.Length - 1; f++)
{
    if (arr[f] % 2 == 0 && arr[f] < max) s += arr[f];
}
Console.WriteLine(s);