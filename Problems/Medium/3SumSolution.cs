namespace LeetCodeProblems.Problems.Medium;

public static class ThreeSumSolution
{
    public static IList<IList<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        var result = new List<IList<int>>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (i > 0 && nums[i] == nums[i - 1])
                continue;

            int l = i + 1;
            int r = nums.Length - 1;

            while (l < r)
            {
                int total = nums[i] + nums[l] + nums[r];

                if (total > 0)
                    r--;
                else if (total < 0)
                    l++;
                else
                {
                    result.Add([nums[i], nums[l], nums[r]]);
                    l++;

                    while (nums[l] == nums[l - 1] && l < r)
                        l++;
                }
            }
        }

        return result;
    }
}
