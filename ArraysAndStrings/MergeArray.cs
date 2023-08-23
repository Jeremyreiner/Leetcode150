namespace demo.ArraysAndStrings
{
    /// <summary>
    /// You are given two integer arrays nums1 and nums2, sorted in non-decreasing order,
    /// and two integers m and n, representing the number of elements in nums1 and nums2 respectively.
    /// Merge nums1 and nums2 into a single array sorted in non-decreasing order.
    /// Input: nums1 = [1,2,3,0,0,0], m = 3, nums2 = [2,5,6], n = 3
    /// Output: [1,2,2,3,5,6]
    /// </summary>
    public class MergeArray
    {
        int[] nums1 = new int[] { 1, 2, 3, 0, 0, 0 };

        int m = 3;

        int[] nums2 = new int[] { 2, 5, 6 };

        int n = 3;

        public MergeArray()
        {
            for (var i = 0; i < n; i++)
                nums1[m + i] = nums2[i];

            Array.Sort(nums1);
        }
    }
}
