// See https://aka.ms/new-console-template for more information

using LeetCode.ArraysAndStrings;

Console.WriteLine("Hello, World!");

var solution = new Solution();

var result = solution.VersionCompare("2", "2.1.90.12");

var status = result switch
{
    < 0 => "less than",
    > 0 => "greater than",
    _ => "equal to"
};

Console.WriteLine($"Version 1 is {status} Version 2");