/*
https://leetcode.com/problems/merge-two-sorted-lists
You are given the heads of two sorted linked lists list1 and list2.
Merge the two lists in a one sorted list. The list should be made by splicing together the nodes of the first two lists.
Return the head of the merged linked list. 
*/
    
    
public ListNode MergeTwoLists(ListNode l1, ListNode l2)
{
    // Validations
    if (l1 == null) return l2;
    if (l2 == null) return l1;

    var newHead = new ListNode(0); // Creating this dummy node ease the logic
    var runnerHead = newHead;        // This is the runner node

    while (l1 != null && l2 != null)
    {
        if (l1.val >= l2.val)
        {
            runnerHead.next = l2;
            l2 = l2.next;
        }
        else
        {
            runnerHead.next = l1;
            l1 = l1.next;
        }

        runnerHead = runnerHead.next;
    }

    if (l1 != null) runnerHead.next = l1;
    if (l2 != null) runnerHead.next = l2;

    return newHead.next;
}
