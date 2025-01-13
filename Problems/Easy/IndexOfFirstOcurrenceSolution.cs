namespace LeetCodeProblems.Problems.Easy;

public static class IndexOfFirstOcurrenceSolution
{
    public static int StrStr(string haystack, string needle)
    {
        for (int i = 0; i <= haystack.Length - needle.Length; i++)
        {
            for (int j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                    break;
                else if (j == needle.Length - 1)
                    return i;
            }
        }

        return -1;
    }
}
