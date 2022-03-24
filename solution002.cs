// Add Two Numbers
// Difficulty: Medium

// Runtime: 110 ms, faster than 73.03% of C# online submissions for Add Two Numbers.
// Memory Usage: 39.3 MB, less than 68.85% of C# online submissions for Add Two Numbers.

/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        // Read linked lists
        var current = l1;
        var value1 = "";

        while (current != null)
        {
            value1 = current.val + value1;

            current = current.next;
        }

        current = l2;
        var value2 = "";

        while (current != null)
        {
            value2 = current.val + value2;

            current = current.next;
        }

        // Get numbers of digits for the loop
        var maxNumberOfDigits = Math.Max(value1.Length, value2.Length);

        // BUild a list to reverse the linked list after creating the sum
        var overflow = false;
        var numbers = new List<int>();
        for (int i = 0; i < maxNumberOfDigits; i++)
        {
            // Read in numbers from the end
            var digit1 = 0;
            var digit2 = 0;
            if (value1.Length > i)
            {
                digit1 = value1[value1.Length - 1 - i] - '0'; // Char to int with " - '0'"
            }
            if (value2.Length > i)
            {
                digit2 = value2[value2.Length - 1 - i] - '0'; // Char to int with " - '0'"
            }

            var calculatedDigit = digit1 + digit2;

            // Add an overflow for the next calculation
            if (overflow)
            {
                calculatedDigit++;
            }

            overflow = false;

            if (calculatedDigit >= 10)
            {
                overflow = true;
                calculatedDigit -= 10;
            }

            numbers.Add(calculatedDigit);
        }

        // Add a 1 if there stil is an overflow
        if (overflow)
        {
            numbers.Add(1);
        }

        // Remove leading zeros but keep at least one
        for (int j = numbers.Count() - 1; j >= 1; j--)
        {
            if (numbers[j] == 0)
            {
                numbers.RemoveAt(j);
            }
            else
            {
                break;
            }
        }

        // Build linked list
        ListNode resultListNode = null;
        for (int k = numbers.Count() - 1; k >= 0; k--)
        {
            resultListNode = new ListNode(numbers[k], resultListNode);
        }

        return resultListNode;
    }
}