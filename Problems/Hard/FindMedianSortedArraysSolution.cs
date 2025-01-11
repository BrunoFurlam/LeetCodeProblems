namespace LeetCodeProblems.Problems.Hard;

public static class FindMedianSortedArraysSolution
{
    public static double FindMedianSortedArrays(int[] nums1, int[] nums2)
    {
        // Median is the central number in an ordered set, if the set contains an odd ammount of elements,
        // or the mean of the two numbers if it contains an even ammount of elements

        // We know in advance that the arrays are sorted, so we only need to look in half of each array

        if (nums1.Length > nums2.Length)
            return FindMedianSortedArrays(nums2, nums1);

        int m = nums1.Length;
        int n = nums2.Length;
        int left = 0;
        int right = m;

        while (left <= right)
        {
            int partA = (left + right) / 2;
            int partB = (m + n + 1) / 2 - partA;

            int maxLeftA = partA == 0 ? int.MinValue : nums1[partA - 1];
            int minRightA = partA == m ? int.MaxValue : nums1[partA];
            int maxLeftB = partB == 0 ? int.MinValue : nums2[partB - 1];
            int minRightB = partB == n ? int.MaxValue : nums2[partB];

            if (maxLeftA <= minRightB && maxLeftB <= minRightA)
            {
                if ((m + n) % 2 == 0)
                    return (Math.Max(maxLeftA, maxLeftB) + Math.Min(minRightA, minRightB)) / 2.0;
                else
                    return Math.Max(maxLeftA, maxLeftB);
            }
            else if (maxLeftA > minRightB)
                right = partA - 1;
            else
                left = partA + 1;
        }

        return 0.0;
    }

    public static void Solve()
    {

    }
}
