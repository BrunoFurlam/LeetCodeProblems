using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCodeProblems.Problems.Medium;

public static class ReverseIntegerSolution
{
    public static int Reverse(int x)
    {
        int rev = 0;
        while (x != 0)
        {
            int pop = x % 10;
            x /= 10;
            if (rev > Int16.MaxValue / 10 ||
                (rev == Int16.MaxValue / 10 && pop > 7))
                return 0;
            if (rev < Int16.MinValue / 10 ||
                (rev == Int16.MinValue / 10 && pop < -8))
                return 0;
            rev = rev * 10 + pop;
        }

        return rev;
    }

    public static void Solve()
    {
        var input = -12345;
        Console.WriteLine($"Input: {input}");
        Console.WriteLine($"Output: {Reverse(input)}");
    }
}
