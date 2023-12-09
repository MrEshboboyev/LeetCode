// See https://aka.ms/new-console-template for more information
using LeetCode;

Console.WriteLine("Hello, World!");

//// this is 1672. Richest Customer Wealth
//int[][] accounts = { [2, 8, 7], [7, 1, 3], [1, 9, 5] };
//var customerWealth = new RichestCustomerWealth1672();
//Console.WriteLine("This is accounts[][] array : ");
//customerWealth.PrintArray(accounts);
//int result = customerWealth.MaximumWealth(accounts);
//Console.WriteLine($"Result : {result}");

// this is 2496. Maximum Value of a String in an Array
string[] array = { "5232", "yv", "22", "c", "yawgs", "928", "4003", "2" };
var maxValueStrArray = new MaximumValueofStringArray2496();
Console.WriteLine(maxValueStrArray.MaximumValue(array));
//maxValueStrArray.IsLetters("90a");
//Console.WriteLine(maxValueStrArray.SumOfDigits("452"));