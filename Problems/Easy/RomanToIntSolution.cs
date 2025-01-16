namespace LeetCodeProblems.Problems.Easy;

public static class RomanToIntSolution
{
    private static Dictionary<char, int> RomanNumbers = new Dictionary<char, int>()
    {
        { 'I', 1 },
        { 'V', 5 },
        { 'X', 10 },
        { 'L', 50 },
        { 'C', 100 },
        { 'D', 500 },
        { 'M', 1000 },
    };

    public static int RomanTonInt(string s)
    {
        int sum = 0;

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];
            int val = RomanNumbers[c];

            if (i + 1 < s.Length && RomanNumbers[s[i + 1]] > val)
                sum -= val;
            else
                sum += val;
        }

        return sum;
    }
}
