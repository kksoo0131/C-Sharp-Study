using System;

public class Solution 
{
    public string solution(string s) 
    {
        int max = int.MinValue;
        int min = int.MaxValue;
        
        string[] intStringArray = s.Split(" ");
        
        foreach(string str in intStringArray)
        {
            int temp = int.Parse(str);
            
            max = Math.Max(max, temp);
            min = Math.Min(min, temp);
        }
        return $"{min} {max}";
    }
}