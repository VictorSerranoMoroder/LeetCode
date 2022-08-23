using System;

class PalindromeLinkedList
{
    public static void Main() {
        
    }

    public bool IsPalindrome(ListNode head) {
        if (head == null)
            return true;
        
        ListNode firstHalfEnd = endOfFirstHalf(head);
        ListNode secondHalfStart = ReverseList(firstHalfEnd.next);
        
        ListNode p1 = head;
        ListNode p2 = secondHalfStart;
        bool result = true;
        
        while (result && p2 != null) {
            if (p1.val != p2.val)
                return false;
            p1 = p1.next;
            p2 = p2.next;
        }
        return result;
    }
    
    private ListNode endOfFirstHalf(ListNode head) {
        ListNode fast = head;
        ListNode slow = head;
        while (fast.next != null && fast.next.next != null) {
            fast = fast.next.next;
            slow = slow.next;
        }
        return slow;
    }
    
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;
        while (curr != null) {
            ListNode nextTemp = curr.next;
            curr.next = prev;
            prev = curr;
            curr = nextTemp;
        }
        return prev;
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
}
