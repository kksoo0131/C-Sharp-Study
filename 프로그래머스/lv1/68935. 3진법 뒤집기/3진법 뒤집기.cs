using System;
public class Solution
    {
        public int solution(int n)
        {

            string str = "";
            int answer = 0;

            while (n >= 3)
            {
                str += n % 3;
                n /= 3;
            }

            str += n;
            
            for (int i=0; i < str.Length; i++)
            {
                answer += int.Parse(str[i].ToString()) * (int)Math.Pow(3, str.Length-1 - i);
            }

           
            return answer;
        }
    }