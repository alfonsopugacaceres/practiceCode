using System;
using static practiceProblems.AddTwoNumbersClasses;

namespace practiceProblems
{
    class AddTwoNumbers
    {
        static void Main(string[] args)
        {
            AddTwoNumbersClasses cls = new AddTwoNumbersClasses();
            ListNode x = new ListNode(2);
            x.next = new ListNode(4);
            x.next.next = new ListNode(3);

            ListNode y = new ListNode(5);
            y.next = new ListNode(6);
            y.next.next = new ListNode(4);

            ListNode z = cls.AddTwoNumbers(x, y);
        }
    }
}
