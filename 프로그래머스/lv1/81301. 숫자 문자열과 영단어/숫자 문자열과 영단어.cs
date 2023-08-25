using System;
    public class Solution
    {
        public int solution(string s)
        {
            // 문자열을 받으면

            // 문자열에 포함된 문자들을 숫자로 바꾸어 return한다.
            s = s.Replace("zero", "0");
            s = s.Replace("one", "1");
            s = s.Replace("two", "2");
            s = s.Replace("three", "3");
            s = s.Replace("four", "4");
            s = s.Replace("five", "5");
            s = s.Replace("six", "6");
            s = s.Replace("seven", "7");
            s = s.Replace("eight", "8");
            s = s.Replace("nine", "9");

            return int.Parse(s);
        }
    }