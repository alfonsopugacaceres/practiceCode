using System;
using System.Collections.Generic;
using System.Text;

namespace integerToRoman
{
    public class Solution
    {
        public string IntToRoman(int num)
        {
            int leftOver = num;
            int repetitions = 0;
            string romanNumeral = new string(String.Empty);

            if(leftOver >= 1000)
            {
                repetitions = leftOver / 1000;
                leftOver = leftOver % 1000; 
                while(repetitions > 0)
                {
                    romanNumeral += "M";
                    repetitions--;
                }
            }
            if(leftOver >= 900)
            { 
                leftOver = leftOver % 900;
                repetitions = 0;
                romanNumeral += "CM";
            }
            if(leftOver >= 500)
            {
                repetitions = leftOver / 500;
                leftOver = leftOver % 500;
                while (repetitions > 0)
                {
                    romanNumeral += "D";
                    repetitions--;
                }
            }
            if(leftOver >= 400)
            {
                leftOver = leftOver % 400;
                repetitions = 0;
                romanNumeral += "CD";
            }
            if(leftOver >= 100)
            {
                repetitions = leftOver / 100;
                leftOver = leftOver % 100;
                while (repetitions > 0)
                {
                    romanNumeral += "C";
                    repetitions--;
                }
            }
            if(leftOver >= 90)
            {
                leftOver = leftOver % 90;
                repetitions = 0;
                romanNumeral += "XC";
            }
            if(leftOver >= 50)
            {
                repetitions = leftOver / 50;
                leftOver = leftOver % 50;
                while (repetitions > 0)
                {
                    romanNumeral += "L";
                    repetitions--;
                }
            }
            if (leftOver >=40)
            {
                leftOver = leftOver % 40;
                repetitions = 0;
                romanNumeral += "XL";
            }
            if (leftOver >= 10)
            {
                repetitions = leftOver / 10;
                leftOver = leftOver % 10;
                while (repetitions > 0)
                {
                    romanNumeral += "X";
                    repetitions--;
                }
            }
            if (leftOver == 9)
            {
                leftOver = leftOver - 9;
                repetitions = 0;
                romanNumeral += "IX";
            }
            if (leftOver >= 5)
            {
                leftOver = leftOver -5;
                repetitions = 0;
                romanNumeral += "V";
            }
            if (leftOver == 4)
            {
                leftOver = 0;
                repetitions = 0;
                romanNumeral += "IV";
            }
            if (leftOver < 4)
            {
                repetitions = 0;
                while (leftOver > 0)
                {
                    romanNumeral += "I";
                    leftOver--;
                }
            }

            return romanNumeral;
        }
    }
}
