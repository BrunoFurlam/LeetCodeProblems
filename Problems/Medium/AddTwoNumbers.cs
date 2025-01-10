namespace LeetCodeProblems.Problems.Medium;

public static class AddTwoNumbersSolution
{
    public class ListNode
    {
        public int val;
        public ListNode? next;
        public ListNode(int val = 0, ListNode? next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return AddTwoNumbers(l1, l2, 0)!;
    }

    private static ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2, int carry)
    {
        if (l1 == null && l2 == null && carry == 0)
            return null;

        var digitSum = carry;

        if (l1 != null)
            digitSum += l1.val;

        if (l2 != null)
            digitSum += l2.val;

        return new ListNode(digitSum % 10, AddTwoNumbers(l1?.next, l2?.next, digitSum / 10)); // Dividing by 10 will truncate the number
    }

    private static ListNode NodesFromList(int[] list)
    {
        ListNode head = new();
        var current = head;
        foreach (var item in list)
        {
            current.next = new ListNode(item);
            current = current.next;
        }
        return head.next;
    }

    private static string WriteNumber(ListNode node)
    {
        var result = "";
        while (node != null)
        {
            result = node.val + result;
            node = node.next;
        }
        return result;
    }

    public static void Solve()
    {
        var l1 = NodesFromList([9, 9, 9, 9, 9, 9, 9]);
        Console.WriteLine($"First number: {WriteNumber(l1)}");

        var l2 = NodesFromList([9, 9, 9, 9]);
        Console.WriteLine($"First number: {WriteNumber(l2)}");

        var result = AddTwoNumbers(l1, l2);
        Console.WriteLine($"Result: {WriteNumber(result)}");
    }
}
