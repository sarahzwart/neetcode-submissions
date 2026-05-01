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
    public ListNode ReverseList(ListNode head) {
        ListNode prev = null;
        ListNode curr = head;

        while(curr != null){
            // temporary node to store the next value of current node
            ListNode temp = curr.next;
            // next value is set to the previous value
            curr.next = prev;
            // previous value is set to the current value
            prev = curr;
            // current value is set to temp (which is curr.next)
            curr = temp;
        }
        return prev;
    }
}
