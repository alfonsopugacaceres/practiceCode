using System;
using System.Collections.Generic;
using System.Text;

namespace practiceProblems
{
    public class AddTwoNumbersClasses
    {
        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }
        }

        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int length = 0;
            ListNode l1Traversal = l1;
            ListNode l2Traversal = l2;
            ListNode newList = null;
            ListNode newListTraversal = null;
            string l1String = String.Empty;
            string l2String = String.Empty;
            int carryOver = 0;
            while (l1Traversal != null && l2Traversal != null)
            {
                l1String += l1Traversal.val.ToString();
                l2String += l2Traversal.val.ToString();
                int sumNums = l1Traversal.val + l2Traversal.val;
                if(sumNums >= 10)
                {
                    carryOver = sumNums / 10;
                    sumNums = sumNums % 10;
                }
                else
                {
                    carryOver = 0;
                }
                sumNums = (sumNums >= 10) ? 0 : sumNums;
                if (newList == null)
                {
                    newListTraversal = new ListNode(sumNums + carryOver);
                    newList = newListTraversal;
                }
                else
                {
                    newListTraversal.next = new ListNode(sumNums);
                    newListTraversal = newListTraversal.next;
                }
                Console.Write("{0} {1} ", sumNums + carryOver, (l1Traversal.next == null) ? "" : "->");
                l1Traversal = l1Traversal.next;
                l2Traversal = l2Traversal.next;
                length++;
            }

            char[] l1Chars = l1String.ToCharArray();
            char[] l2Chars = l2String.ToCharArray();
            Array.Reverse(l1Chars);
            Array.Reverse(l2Chars);

            Console.WriteLine("{0} + {1} = {2}", new String(l1Chars), new String(l2Chars), (Convert.ToInt32(new String(l1Chars))) + (Convert.ToInt32(new String(l2Chars))));

            return newList;
        }


    };
}