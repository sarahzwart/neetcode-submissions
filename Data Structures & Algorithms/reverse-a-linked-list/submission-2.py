# Definition for singly-linked list.
# class ListNode:
#     def __init__(self, val=0, next=None):
#         self.val = val
#         self.next = next

class Solution:
    def reverseList(self, head: Optional[ListNode]) -> Optional[ListNode]:
        prev, curr = None, head
        while curr:
            temp = curr.next # store next value
            curr.next = prev # set next value equal to the previous
            prev = curr # set previous value equal to the current value
            curr = temp # set current value equal to the value in the list
        return prev
