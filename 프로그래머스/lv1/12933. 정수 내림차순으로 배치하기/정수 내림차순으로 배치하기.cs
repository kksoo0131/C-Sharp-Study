using System;
public class Solution
    {
        public long solution(long n)
        {
            long answer = 0;
            char[] charArray = n.ToString().ToCharArray();

            Array.Sort(charArray);
            Array.Reverse(charArray);
            
            string str = new string(charArray);
            
            return long.Parse(str);
        }
    }