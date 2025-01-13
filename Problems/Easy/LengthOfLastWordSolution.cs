namespace LeetCodeProblems.Problems.Easy;

public static class LengthOfLastWordSolution
{
    public static int LengthOfLastWord(string s)
    {
        int len = 0;
        for (int i = s.Length - 1; i >= 0; i--)
        {
            if (s[i] != ' ')
                len++;
            else if (s[i] == ' ' && len > 0)
                break;
        }
        return len;
    }
}
