using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo.ArraysAndStrings
{
    /// <summary>
    /// Given an integer array nums and an integer val, remove all occurrences of val in nums in-place.
    /// The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.
    /// Consider the number of elements in nums which are not equal to val be k, to get accepted,
    /// you need to do the following things:
    ///     int[] nums = [...]; // Input array
    /// int val = ...; // Value to remove
    /// </summary>
    public class RemoveAt
    {
        private int[] nums = new int[] { 3, 2, 2, 3 };
        private int val = 3;

        public int RemoveElement()
        {
            var current = 0;

            for (var i = 0; i < nums.Length; i++)
            {
                if (nums[i] == val) continue;
                
                nums[current] = nums[i];
                
                current++;
            }

            return current;
        }
    }
}
