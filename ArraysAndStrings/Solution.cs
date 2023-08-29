using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.ArraysAndStrings
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
            int[] nums = {1, 2, 3, 4, 5, 6, 7};

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
    }
}
