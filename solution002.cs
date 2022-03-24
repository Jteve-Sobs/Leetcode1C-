//todo: weitermachen
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
        //Console.WriteLine(l1.val);
        //Console.WriteLine(l1.next.val);
        //Console.WriteLine(l1.next.next.val);
        //Console.WriteLine(l1.next.next.next.val); -> null
        
        var current = l1;
        var factor = 1;
        // Value muss in string umgebaut werden wegen Bufferoverflow
        var value1 = 0;
        
        while(current != null)
        {
            value1 += current.val * factor;
            
            factor *= 10;
            current = current.next;
        }
        
        Console.WriteLine(value1);
        
        current = l2;
        factor = 1;
        var value2 = 0;
        
        while(current != null)
        {
            value2 += current.val * factor;
            
            factor *= 10;
            current = current.next;
        }
        
        Console.WriteLine(value2);
        
        var result = value1 + value2;
        Console.WriteLine(result);
        
        ListNode resultListNode = null;// = new ListNode(result.ToString()[0] - '0');
        for(int i = 0; i < result.ToString().Length; i++)
        {
            // Char to int with " - '0'"
            resultListNode = new ListNode(result.ToString()[i] - '0', resultListNode);
        }    
        
        return resultListNode;
    }
}