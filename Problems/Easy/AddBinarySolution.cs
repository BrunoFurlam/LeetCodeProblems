namespace LeetCodeProblems.Problems.Easy;

public class AddBinarySolution
{
    public static string AddBinary(string a, string b)
    {
        int maxLenght = Math.Max(a.Length, b.Length);
        char[] buffer = new char[maxLenght + 1];

        int carry = 0;
        for (int i = 1; i <= maxLenght; i++)
        {
            if (i <= a.Length)
                carry += a[^i] - '0';

            if (i <= b.Length)
                carry += b[^i] - '0';

            buffer[^i] = (char)(carry % 2 + '0');
            carry /= 2;
        }

        if (carry != 0)
        {
            buffer[0] = '1';
            return new string(buffer);
        }
        else
            return new string(buffer[1..]);
    }

    public static void Solve()
    {
        string a = "0";
        Console.WriteLine($"First input: {a}");

        string b = "0";
        Console.WriteLine($"Second input: {b}");

        Console.WriteLine($"{AddBinary(a, b)}");
    }
}
