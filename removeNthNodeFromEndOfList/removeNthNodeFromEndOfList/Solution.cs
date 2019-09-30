using System;
using System.Collections.Generic;
using System.Text;

namespace removeNthNodeFromEndOfList
{
    public class Solution
    { 
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode traversal = head;
            IList<ListNode> nodeList = new List<ListNode>();
            while (traversal != null)
            {
                nodeList.Add(traversal);
                traversal = traversal.next;
            }

            int maxIndex = nodeList.Count - 1;

            if(nodeList.Count <= 1 && n >=1)
            {
                return null;
            }
            else if(maxIndex - n == 0)
            {
                nodeList[maxIndex - n].next = null;
                nodeList.RemoveAt(maxIndex - n);
            }
            else
            {
                nodeList[(maxIndex - n) - 1].next = ((maxIndex - n) + 1 > nodeList.Count-1) ? null : nodeList[(nodeList.Count - n) + 1];
                nodeList[(maxIndex - n)].next = null;
                nodeList.RemoveAt(maxIndex - n);
            }


            return head;
        }
    }
}
