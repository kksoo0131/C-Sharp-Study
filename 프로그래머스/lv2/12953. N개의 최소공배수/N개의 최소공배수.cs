using System;

public class Solution 
{
    // 최소공배수는
    
    // a * b / gcd(a,b) 임
    
    public int solution(int[] arr) 
    {
        int pivot = arr[0];
        
        foreach(int i in arr)
        {
            int max = Math.Max(pivot, i);
            int min = Math.Min(pivot, i);
            
            pivot = max * min / gcd(max,min);
        }
        
        return pivot;
    }
    
    public int gcd(int a,int b)
    {
        int r = a % b;
        
        return r == 0 ? b : gcd(b,r);        
    }
}