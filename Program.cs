// See https://aka.ms/new-console-template for more information
using DotNet_DSA;
using DotNet_DSA.StringManupilation;

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


//---------------------------------------------------------------------------------------------------------------
RemoveDuplicateCharacterFrom_String removeDuplicateCharacterFrom_String = new RemoveDuplicateCharacterFrom_String();

Console.WriteLine(removeDuplicateCharacterFrom_String.RemoveDuplicateChar("hello"));
Console.WriteLine(removeDuplicateCharacterFrom_String.RemoveDuplicateChar1("hello1"));


//----------------segregate0and1--------------
int[] arrForSeg = { 0,1,1,0,0,1};

Segregate0sand1s seg=new Segregate0sand1s();
int[] arrcheck=seg.segregate0and1(arrForSeg,6);
foreach (int i in arrcheck)
{
    Console.Write(i + ",");
}
//----------------------------check string palindrome

string palindrome = "abba";
Palindrome palindrome1 = new Palindrome();
Console.WriteLine("Check palindrome :" + palindrome1.isPalindrome(palindrome));

//-------------------Remoe Duplicate array element
int[] arr123 = { 1, 1, 2, 2,2,3, 4 };
RemoveDuplicateFromArray removeDuplicateFromArray = new RemoveDuplicateFromArray();

int size = removeDuplicateFromArray.RemoveDuplicate(arr123, 7);

Console.WriteLine(size);
