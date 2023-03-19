using System;

class Solution
{
    public int solution(int n)
    {
        return move(n);
    }
    
    int move(int n){
        if (n == 1)
            return 1;
        
        if (n % 2 == 0)
            return move(n/2);
        return move(n/2) + move(1);
    }
    
    
}