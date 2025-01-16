using System.Text;

namespace LeetCodeProblems.Problems.Easy;

public static class LongestCommonPrefixSolution
{
    public static string LongestCommonPrefix(string[] strs)
    {
        string s = "";

        for (int j = 0; j < strs[0].Length; j++)
        {
            for (int i = 1; i < strs.Length; i++)
            {
                if (j >= strs[i].Length || strs[i][j] != strs[0][j])
                    return s;
            }
            s += strs[0][j];
        }

        return s;
    }
}
