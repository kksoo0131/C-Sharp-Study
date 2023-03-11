using System;

class Solution 
{
    public int solution(int n) 
   {
         int num_1 = Convert.ToString(n++, 2).Replace("0","").Length;
        while(Convert.ToString(n,2).Replace("0", "").Length != num_1)
        {
            n +=1;
        }
        return n;
    }
}