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

//// this is 2496. Maximum Value of a String in an Array
//string[] array = { "5232", "yv", "22", "c", "yawgs", "928", "4003", "2" };
//var maxValueStrArray = new MaximumValueofStringArray2496();
//Console.WriteLine(maxValueStrArray.MaximumValue(array));
////maxValueStrArray.IsLetters("90a");
////Console.WriteLine(maxValueStrArray.SumOfDigits("452"));
///

//int[] nums1 = [0], nums2 = [1];
//int m = 0, n = 1;
//var merge = new MergeSortedArray88();
//int[] nums = merge.Merge(nums1, m, nums2, n);
//for (int i = 0; i < nums.Length; i++)
//{
//    Console.WriteLine(nums[i]);
//}

//// this is 1556. Thousand Separator
//var separator = new ThousandSeparator1556();
//string txt = "Hello, World!";
//Console.WriteLine(txt);
//txt.Remove(1, 3);
//Console.WriteLine(txt);

//int n = 123456789;
//string result = separator.ThousandSeparator(n);
//Console.WriteLine(result);

//// this is 929. Unique Email Addresses
//var uniqueEmail = new UniqueEmailAddresses929();
//string[] emails = ["test.email+alex@leetcode.com", 
//    "test.e.mail+bob.cathy@leetcode.com", 
//    "testemail+david@lee.tcode.com"];
//int uniqueEmailAddresses = uniqueEmail.NumUniqueEmails(emails);
//Console.WriteLine(uniqueEmailAddresses);

//// this is 1859. Sorting the Sentence
//var sorting = new SortingSentence1859();
//string s = "Myself2 Me1 I4 and3";
//string result = sorting.SortSentence(s);
////Print.PrintDictionary(dict);
//Console.WriteLine(result);


//#region 1897. Redistribute Characters to Make All Strings Equal
//var stringEqual = new RedistributeCharacterstoMakeAllStringsEqual1897();
//string[] words = ["caaaaa", "aaaaaaaaa", "a", "bbb", "bbbbbbbbb", "bbb", "cc", "cccccccccccc", "ccccccc", "ccccccc", "cc", "cccc", "c", "cccccccc", "c"];
////Dictionary<char, int> map = stringEqual.MakeEqual(words);
////Print.PrintDictionary(map);
//bool res = stringEqual.MakeEqual(words);
//Console.WriteLine(res);
//#endregion

//#region 724. Find Pivot Index
//var pivotIndex = new FindPivotIndex724();
//int[] nums = [1, 7, 3, 6, 5, 6];
//int res = pivotIndex.PivotIndex(nums);
//Console.WriteLine(res);
//#endregion

//#region 1991. Find the Middle Index in Array
//var middleIndex = new FindTheMiddleIndexInArray1991();
//int[] nums = [1, 7, 3, 6, 5, 6];
//int res = middleIndex.FindMiddleIndexSolution(nums);
//Console.WriteLine(res);
//#endregion

#region 1403. Minimum Subsequence in Non-Increasing Order
var subOrder = new MinimumSubsequenceInNon_IncreasingOrder1403();
int[] nums = [4, 4, 7, 6, 7];
IList<int> res = subOrder.MinSubsequenceSolution(nums);
Console.WriteLine("Natijaviy array : ");
foreach (var item in res)
{
    Console.Write(item + " ");
}
#endregion