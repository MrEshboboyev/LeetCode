// See https://aka.ms/new-console-template for more information
using LeetCode;

Console.WriteLine("Hello, World!");

// this is 1672. Richest Customer Wealth
int[][] accounts = { [2, 8, 7], [7, 1, 3], [1, 9, 5] };
var customerWealth = new RichestCustomerWealth1672();
Console.WriteLine("This is accounts[][] array : ");
customerWealth.PrintArray(accounts);
int result = customerWealth.MaximumWealth(accounts);
Console.WriteLine($"Result : {result}");