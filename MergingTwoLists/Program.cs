using System;

public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}

public class Solution
{
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        // Initialize dummy node and current node
        ListNode dummy = new ListNode();
        ListNode current = dummy;

        // Merge the two lists
        while (list1 != null && list2 != null)
        {
            if (list1.val <= list2.val)
            {
                current.next = list1;
                list1 = list1.next;
            }
            else
            {
                current.next = list2;
                list2 = list2.next;
            }
            current = current.next;
        }

        // Attach the remaining nodes of list1 or list2
        current.next = list1 ?? list2;

        // Print merged list for debugging
        PrintList(dummy.next);

        // Return the merged list
        return dummy.next;
    }

    // Method to print the linked list
    private void PrintList(ListNode node)
    {
        while (node != null)
        {
            Console.Write(node.val + " -> ");
            node = node.next;
        }
        Console.WriteLine("null");
    }
}

// Example usage
class Program
{
    static void Main()
    {
        // Creating example lists
        ListNode list1 = new ListNode(1, new ListNode(3, new ListNode(5)));
        ListNode list2 = new ListNode(2, new ListNode(4, new ListNode(6)));

        Solution solution = new Solution();
        ListNode mergedList = solution.MergeTwoLists(list1, list2);

        Console.WriteLine("Merged List:");
        // The PrintList method is called within the MergeTwoLists method
    }
}
