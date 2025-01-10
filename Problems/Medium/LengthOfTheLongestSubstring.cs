namespace LeetCodeProblems.Problems.Medium;

public class LengthOfTheLongestSubstringSolution
{
    public static int LengthOfLongestSubstring(string s)
    {
        if (string.IsNullOrEmpty(s))
            return 0;

        // Dictionary to store the last index of each character
        var lastSeen = new Dictionary<char, int>();

        int maxLen = 0;
        int left = 0;  // Left boundary of the sliding window

        for (int right = 0; right < s.Length; right++)
        {
            char c = s[right];

            // If we've seen the character and it's inside the current window...
            if (lastSeen.ContainsKey(c) && lastSeen[c] >= left)
            {
                // Move the left boundary to one position after the last occurrence
                left = lastSeen[c] + 1;
            }

            // Update the last seen index of the current character
            lastSeen[c] = right;

            // Update the max length if needed
            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }

    public static void Solve()
    {
        var inputString = "tmmzuxt";
        Console.WriteLine($"Input: {inputString}");
        Console.WriteLine($"Result: {LengthOfLongestSubstring(inputString)}");
    }
}
