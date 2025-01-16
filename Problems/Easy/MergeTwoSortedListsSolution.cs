using System.Text;

namespace LeetCodeProblems.Problems.Easy;

public static class MergeTwoSortedListsSolution
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

    public static ListNode? MergeTwoLists(ListNode? list1, ListNode? list2)
    {
        if (list1 == null)
            return list2;
        else if (list2 == null)
            return list1;

        if (list1.val < list2.val)
        {
            list1.next = MergeTwoLists(list1.next, list2);
            return list1;
        }
        else
        {
            list2.next = MergeTwoLists(list1, list2.next);
            return list2;
        }
    }

    private static ListNode? NodesFromList(int[] list)
    {
        if (list.Length == 0)
            return null;

        var node = new ListNode(list[list.Length - 1]);

        for (int i = list.Length - 2; i >= 0; i--)
            node = new ListNode(list[i], node);

        return node;
    }

    private static string WriteList(ListNode? node)
    {
        var sb = new StringBuilder();

        sb.Append('[');
        while (node != null)
        {
            sb.Append(node.val);

            if (node.next != null)
                sb.Append(',');

            node = node.next;
        }
        sb.Append(']');

        return sb.ToString();
    }

    public static void Solve()
    {
        var l1 = NodesFromList([1, 2, 4]);
        Console.WriteLine($"First array: {WriteList(l1)}");

        var l2 = NodesFromList([1, 3, 4]);
        Console.WriteLine($"Second array: {WriteList(l2)}");

        var result = MergeTwoLists(l1, l2);
        Console.WriteLine($"Result: {WriteList(result)}");
    }
}
