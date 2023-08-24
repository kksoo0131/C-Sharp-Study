using System.Collections.Generic;
public class Solution
    {
        public string solution(string s)
        {
            List<char> list = new List<char>();
            foreach (char c in s)
            {
                list.Add(c);
            }

            list.Sort();
            list.Reverse();

            return new string(list.ToArray());
        }
    }