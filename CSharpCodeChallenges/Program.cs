// See https://aka.ms/new-console-template for more information
using CSharpCodeChallenges.Samples;

string str = "Kamesh";
//Console.WriteLine("Input : " + Input);
//ReverseInputString reverseInputString = new ReverseInputString();
//var reversestring = reverseInputString.ReverseAllWords(Input.ToCharArray());
//Console.WriteLine("Reverse String output1 : " + string.Join("", reversestring));
//Console.WriteLine("Reverse String output without inbuilt function : " + reverseInputString.ReverseString(Input));
//Console.ReadLine();

CodeChallenges.ReverseString(str);
Console.WriteLine("=====================================");
CodeChallenges.chkPalindrome(str);
Console.WriteLine("=====================================");
CodeChallenges.chkPalindrome("madam");
Console.WriteLine("=====================================");
CodeChallenges.ReverseWordOrder("Welcome to Csharp corner");
Console.WriteLine("=====================================");
CodeChallenges.ReverseWords("Welcome to Csharp corner");
Console.WriteLine("=====================================");
CodeChallenges.Countcharacter("Welcome to Csharp corner");
Console.WriteLine("=====================================");

CodeChallenges.Countcharacter("Welcome to Csharp corner");
Console.WriteLine("=====================================");

CodeChallenges.removeduplicate("Hello");
Console.WriteLine("=====================================");
Console.WriteLine("Accept number:");
var number = Convert.ToInt32(Console.ReadLine());
CodeChallenges.FindPrime(number);
Console.WriteLine("=====================================");

CodeChallenges.SumOfDigits(1221);
Console.WriteLine("=====================================");
int[] arr  = { 2, 5, 3, 9, 4, 7 };

CodeChallenges.FindSecondLargeInArray(arr);

Console.WriteLine("=====================================");


Console.ReadLine();