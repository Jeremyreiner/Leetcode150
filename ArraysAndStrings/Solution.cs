using System;
using System.Text;
using LeetCode.Extensions;

namespace LeetCode.ArraysAndStrings
{
    public class Solution
    {
        /// <summary>
        /// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
        /// and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
        /// Merge nums1 and nums2 into a single array sorted in non-decreasing order.
        /// Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
        /// Output: [1,2,2,3,5,6]
        /// </summary>
        public void MergeArray()
        {
            int[] nums1 = { 1, 2, 3, 0, 0, 0 };

            var m = 3;

            int[] nums2 = { 2, 5, 6 };

            var n = 3;

            for (var i = 0; i < n; i++)
                nums1[m + i] = nums2[i];

            Array.Sort(nums1);
        }

        /// <summary>
        /// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.
        /// The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
        /// Consider the number of elements in nums which are not equal to val be k, to get accepted,
        /// you need to do the following things:
        ///     int[] nums = [...]; // Input array
        /// int val = ...; // Value to remove
        /// </summary>
        public int RemoveElement()
        {

            int[] nums = { 3, 2, 2, 3 };

            var val = 3;

            var current = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val) continue;

                nums[current] = nums[i];

                current++;
            }

            return current;
        }

        /// <summary>
        /// Given an integer array nums, rotate the array to the right by k steps, where k is non-negative.
        /// Input: nums = [1,2,3,4,5,6,7], k = 3
        /// Output: [5,6,7,1,2,3,4]
        /// </summary>
        public void Rotate()
        {
            int[] nums = { 1, 2, 3, 4, 5, 6, 7 };

            var k = 3;

            var n = nums.Length;

            var rotatedArray = new int[n];

            for (var i = 0; i < n; i++)
            {
                var newIndex = (i + k) % n;

                rotatedArray[newIndex] = nums[i];
            }

            Array.Copy(rotatedArray, nums, n);
        }

        /// <summary>
        /// You are given an array prices where prices[i] is the price of a given stock on the ith day.
        /// You want to maximize your profit by choosing a single day to buy one stock and choosing a different day in the future to sell that stock.
        /// Return the maximum profit you can achieve from this transaction.If you cannot achieve any profit, return 0.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfit()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };

            var minPrice = int.MaxValue;

            var maxProfit = 0;

            foreach (var price in prices)
            {
                if (price < minPrice)
                    minPrice = price;

                var profit = price - minPrice;

                if (profit > maxProfit)
                    maxProfit = profit;
            }
            return maxProfit;
        }

        /// <summary>
        /// You are given an integer array prices where prices[i] is the price of a given stock on the ith day.
        /// On each day, you may decide to buy and/or sell the stock.You can only hold at most one share of the stock at any time.
        /// However, you can buy it then immediately sell it on the same day.
        /// Find and return the maximum profit you can achieve.
        /// </summary>
        /// <param name="prices"></param>
        /// <returns></returns>
        public int MaxProfitII()
        {
            int[] prices = { 7, 1, 5, 3, 6, 4 };

            var profit = 0;

            for (var i = 1; i < prices.Length; i++)
            {
                if (prices[i] > prices[i - 1])
                    profit += prices[i] - prices[i - 1];
            }

            return profit;
        }

        /*
         * For example, 2 is written as II in Roman numeral, just two ones added together.
         * 12 is written as XII, which is simply X + II. The number 27 is written as XXVII, which is XX + V + II.
           Roman numerals are usually written largest to smallest from left to right. However, the numeral for four is not IIII. 
           Instead, the number four is written as IV. Because the one is before the five we subtract it making four. 
           The same principle applies to the number nine, which is written as IX. There are six instances where subtraction is used:

           I can be placed before V (5) and X (10) to make 4 and 9. 
           X can be placed before L (50) and C (100) to make 40 and 90. 
           C can be placed before D (500) and M (1000) to make 400 and 900.
           Given a roman numeral, convert it to an integer.
         */
        public int RomanToInt(string s)
        {
            var romanDigits = new Dictionary<char, int>(){
                {'I',1},
                {'V',5},
                {'X',10},
                {'L',50},
                {'C',100},
                {'D',500},
                {'M',1000}
            };

            var result = 0;

            for (var i = 0; i < s.Length - 1; i++)
            {
                if (romanDigits[s[i]] < romanDigits[s[i + 1]])
                    result -= romanDigits[s[i]];
                else
                    result += romanDigits[s[i]];
            }

            return result + romanDigits[s[s.Length - 1]];
        }

        public int VersionCompare(string version1, string version2)
        {
            var v1 = version1.ValidVersion();
            var v2 = version2.ValidVersion();

            var result = v1.CompareTo(v2);

            if (result == 0)
                return 0;

            return result > 0
                ? 1
                : -1;
        } 
    }
}
