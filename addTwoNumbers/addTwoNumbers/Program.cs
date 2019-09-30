using System;

namespace addTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Solution x = new Solution();
            Solution.ListNode in1 = new Solution.ListNode(2);
            in1.next = new Solution.ListNode(4);
            in1.next.next = new Solution.ListNode(3);
            Solution.ListNode in2 = new Solution.ListNode(5);
            in2.next = new Solution.ListNode(6);
            in2.next.next = new Solution.ListNode(4);

            Solution.ListNode answer = x.AddTwoNumbers(in1, in2);

            while(answer != null)
            {
                Console.Write(" {0} -> ", answer.val);
                answer = answer.next;
            }
        }
    }
}
