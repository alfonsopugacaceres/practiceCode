using System;
using System.Collections.Generic;
using System.Text;

namespace test
{
    public class Solution4
    {
        public int minimumDistance(int numRows, int numColumns, int[,] area)
        {

            int destinationX = -1;
            int destinationY = -1;
            int targetX = -1;
            int targetY = -1;
            for (int i = 0; i < numRows; i++)
            {
                for(int j = 0; j < numColumns; j++)
                {
                    if(area[i,j] == 9)
                    {
                        destinationX = i;
                        destinationY = j;
                    }
                    else if(area[i,j] == 1)
                    {
                        area[i, j] = i + j; 
                    }
                    else
                    {

                    }
                }
            }
            targetX = destinationX;
            targetY = destinationY;
            while (targetX != 0 && targetY != 0)
            {
                if(area[targetX - 1,targetY])
            }
        }


    }
}
