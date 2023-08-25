using System;
using System.Collections.Generic;
public class Solution
    {
        public int[] solution(string s)
        {
            // 자신이 중복된 글자인지 확인해서
            // 중복이라면 앞에 있는 칸을 return
            Dictionary<char, int> dic = new Dictionary<char, int>();
            List<int> answer = new List<int>();

            for (int i =0; i< s.Length; i++)
            {
                if (dic.ContainsKey(s[i]))
                {
                    answer.Add(i - dic[s[i]]);
                }
                else
                {
                    answer.Add(-1);
                    
                }

                dic[s[i]] = i;
            }
            
    

            return answer.ToArray();
        }
    }