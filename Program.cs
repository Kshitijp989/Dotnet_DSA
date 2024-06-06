// See https://aka.ms/new-console-template for more information
using DotNet_DSA;

Console.WriteLine("Hello, World!");
int[] arr =  { 3, 2, 4 };
TwoSum two=new TwoSum();
int[] arrtwo=two.TwoSumMethod(arr, 6);
foreach (int i in arrtwo)
{
    Console.WriteLine("index" +i);
}
int[] miss = { 1, 2, 3, 5 };
MissingNumber missing = new MissingNumber();
int ans= missing.MissingNumberFromArray(miss, 5);
Console.WriteLine(ans);



