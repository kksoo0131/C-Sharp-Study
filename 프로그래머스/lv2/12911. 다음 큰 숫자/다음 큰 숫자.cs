using System;

class Solution 
{
    public int solution(int n) 
   {
        string temp = "";
        int n_of_one = 0;
        temp = Convert.ToString(n, 2);
        n_of_one = temp.Replace("0","").Length;
        while(true){
            n +=1;
            temp = Convert.ToString(n,2);
            if(temp.Replace("0", "").Length == n_of_one)
                break;
        }

        return n;
    }
}