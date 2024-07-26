// See https://aka.ms/new-console-template for more information
using CSharpCodeChallenges.Samples;

string Input = "Kamesh";
Console.WriteLine("Input : " + Input);
ReverseInputString reverseInputString = new ReverseInputString();
var reversestring = reverseInputString.ReverseAllWords(Input.ToCharArray());
Console.WriteLine("Reverse String output1 : " + string.Join("", reversestring));
Console.WriteLine("Reverse String output without inbuilt function : " + reverseInputString.ReverseString(Input));
Console.ReadLine();
