namespace LeetCodeProblems.Problems.Easy;

public static class ValidParentesisSolution
{
    public static bool IsValid(string s)
    {
        var stack = new Stack<char>();

        for (int i = 0; i < s.Length; i++)
        {
            char c = s[i];

            if (c == '(' || c == '[' || c == '{')
                stack.Push(c);
            else if (stack.Count == 0)
                return false;
            else
            {
                char l = stack.Pop();
                if ((l == '(' && c != ')') || (l == '[' && c != ']') || (l == '{' && c != '}'))
                    return false;
            }
        }

        return stack.Count == 0;
    }
}
