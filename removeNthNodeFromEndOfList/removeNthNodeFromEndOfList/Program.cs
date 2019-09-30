using System;

namespace removeNthNodeFromEndOfList
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution x = new Solution();
            Solution.ListNode head = new Solution.ListNode(1);
            head.next = new Solution.ListNode(2);
            //head.next.next = new Solution.ListNode(3);
            //head.next.next.next = new Solution.ListNode(4);
            //head.next.next.next.next = new Solution.ListNode(5);
            x.RemoveNthFromEnd(head, 1);
        }
    }
}
 