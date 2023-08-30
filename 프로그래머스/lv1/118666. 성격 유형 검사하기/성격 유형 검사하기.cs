using System;
using System.Collections.Generic;

public class Solution
    {
        public string solution(string[] survey, int[] choices)
        {
            // 질문의 유형에 따라서 배점이 정해지고
            // 1~3은 앞문자, 4는 둘다 0점, 5~7 은 뒷문자의 점수를 얻는다.
            // 3 2 1, 1 2 3점
            // 그래서 각 성격유형의 점수를 모두 합쳐서 사전순으로 return한다.

            // 일단 survey를 index 0과 1로 나눔

            // 성격유형을 사전순으로만 생각
            // RT, CF, JM, AN
            // survey를 확인하고 사전순인지 역순인지 확인.

            Dictionary<string, int> dic = new Dictionary<string, int>();
            string[] order = new string[] { "RT", "CF", "JM", "AN" };
            string answer = "";
            
            foreach(string s in order)
            {
                dic.Add(s,0);
            }
            
            for (int i = 0; i < survey.Length; i++)
            {
                string s = survey[i];
                int choice = choices[i];
                int[] score = new int[] { 3, 2, 1, 0, -1, -2, -3 };
                
                string key = "";

                // key를 사전순으로 정렬
                if (s[0] - s[1] > 0)
                {
                    key += s[1];
                    key += s[0];
                    Array.Reverse(score);
                }
                else
                {
                    key = s;
                }
                
                dic[key] += score[choice-1];
            }

            foreach (string s in order)
            {
                answer += dic[s] >= 0 ? s[0] : s[1];
            }
            return answer;
        }   
    }