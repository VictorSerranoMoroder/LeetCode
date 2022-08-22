using System;

class AddTwoNumbers
{
	public static void Main()
	{
        int[] array1 = {1,2,4,9};
        int[] array2 = {3,4};
        ListNode node1 = new ListNode(array1[0], fillListNode(array1, 1));
        ListNode node2 = new ListNode(array2[0], fillListNode(array2, 1));

        Solution.AddTwoNumbers(node1,node2).readListNode();
	}

    private static ListNode fillListNode(int[] array, int index) {
        if (index < array.Length)
            return new ListNode(array[index], fillListNode(array,index+1));
        else
            return null;
    }

}


//Definition for singly-linked list.
public class ListNode {
    public int val;
    public ListNode next;
    public ListNode(int val=0, ListNode next=null) {
        this.val = val;
        this.next = next;
    }
    public void readListNode() {
        Console.Write(val);
        if (next != null)
            next.readListNode();
    }
    public void addNode(int value) {
        if (next == null)
            next = new ListNode(value, null);
        else {
            if (val < 0) 
                val = value;
            else
                next.addNode(value);
        }          
    }
}


public class Solution {
    public static ListNode AddTwoNumbers(ListNode l1, ListNode l2) {

        int num1 = 0, num2 = 0, carry = 0, value = 0;
        ListNode headList = null, list = null;
        bool isHead = true;

        while (l1 != null || l2 != null) {
            num1 = 0;
            num2 = 0;

            if (l1 != null) 
                num1 = l1.val;
            if (l2 != null) 
                num2 = l2.val;
            
            value = num1 + num2 + carry;
            if (value - 10 >= 0)
                carry = 1;
            else
                carry = 0;
            
            value %= 10;

            if (isHead) {
                headList = new ListNode(value, null);
                isHead = false;
            }
            else {
                if (headList.next == null) {
                    headList.next = new ListNode(value, null);
                    list = headList.next;
                }
                else {
                    list.addNode(value);
                }
                
            }
            
            if (l1 != null)
                l1 = l1.next;
            if (l2 != null)
                l2 = l2.next;
        }
        return headList;
    }
}