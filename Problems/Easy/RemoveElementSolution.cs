namespace LeetCodeProblems.Problems.Easy;

public static class RemoveElementSolution
{
    public static int RemoveElement(int[] nums, int val)
    {
        int k = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == val)
                k++;
            else
                nums[i - k] = nums[i];
        }
        return nums.Length - k;
    }

    public static void Solve()
    {
        var input = new int[] { 0, 1, 2, 2, 3, 0, 4, 2 };
        var output = RemoveElement(input, 2);
    }
}
