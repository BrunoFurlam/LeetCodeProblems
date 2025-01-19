namespace LeetCodeProblems.Problems.Medium;

public static class ZigzagConversionSolution
{
    public static string Convert(string s, int numRows)
    {
        if (numRows <= 1)
            return s;

        var r = new char[s.Length];

        // PAYPALISHIRING
        //
        // NROWS = 3
        // P   I   H   N
        // A P L S I I G
        // Y   I   R
        //
        // NROWS = 4
        // P     I     N
        // A   L S   I G
        // Y A   H R
        // P     I
        //
        // NROWS = 5
        // P       H
        // A     S I
        // Y   I   R
        // P L     I G
        // A       N

        int cycle = (numRows - 1) * 2;
        int idx = 0;

        for (int row = 0; row < numRows; row++)
        {
            for (int i = row; i < s.Length; i += cycle)
            {
                r[idx] = s[i];
                idx++;

                if (row > 0 && row < numRows - 1)
                {
                    int k = i + cycle - (row << 1);
                    if (k < s.Length)
                    {
                        r[idx] = s[k];
                        idx++;
                    }
                }
            }
        }

        return new string(r);
    }

    public static void Solve()
    {
        Console.WriteLine("Input String: PAYPALISHIRING");
        Console.WriteLine("Input Rows: 5");
        Console.WriteLine($"Result: {Convert("PAYPALISHIRING", 5)}");
    }
}
