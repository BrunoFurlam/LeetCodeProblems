namespace LeetCodeProblems.Problems.Easy;

public static class TwoSumSolution
{
    public static int[] TwoSum(int[] nums, int target)
    {
        var map = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            var number = nums[i];
            if (map.TryGetValue(target - number, out var j))
                return [i, j];
            else
                map[number] = i;
        }

        return [];
    }
}
