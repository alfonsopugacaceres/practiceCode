using System;
using System.Collections.Generic;
using System.Text;

namespace addTwoNumbers
{
    public class Solution
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {  
            string answerString = String.Empty;
            int carryOver = 0;
            while(l1 != null || l2 != null)
            {
                int temp = ((l1 == null) ? 0 : l1.val) + ((l2 == null) ? 0 : l2.val) + carryOver;
                if(temp >= 10)
                {
                    answerString += (temp % 10).ToString();
                    carryOver = temp / 10;
                }
                else
                {
                    answerString += (temp).ToString();
                    carryOver = 0;
                }
                if(l1 != null)
                    l1 = l1.next;
                if (l2 != null)
                    l2 = l2.next;
            }
            if(carryOver > 0)
            {
                answerString += carryOver;
            }


            string toNodes = answerString;
            ListNode ret = null;
            for(int i = toNodes.Length; i > 0; i--)
            {
                if(ret != null)
                {
                    ListNode temporaryNode = ret;
                    ret = new ListNode((int)(toNodes[i - 1] -'0'));
                    ret.next = temporaryNode;
                }
                else
                {
                    ret = new ListNode((int)(toNodes[i - 1] - '0'));
                }
            }

            return ret;
        }
    }
}
