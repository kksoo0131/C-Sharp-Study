using System;

public class Solution
{
    public string solution(string s, string skip, int index)
    {
        string answer = "";
        foreach ( char c in s)
        {
            int start = c;
           for (int i =0; i < index; i++){
               
               start = start + 1;
               if (start == 123)
                   start = 97;
               if (skip.Contains((char)start))
                   i -=1;               
           }
            answer += (char)start;
        }
        
        return answer;
    } 
}
