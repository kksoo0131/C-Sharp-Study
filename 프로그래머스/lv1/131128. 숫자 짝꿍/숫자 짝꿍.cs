using System;
using System.Text;

public class Solution
    {
        // X와 Y에서 공통으로 존재하는 요소들을 가져와서 가장 큰 정수를 만들어라
        // 없다면 -1
        // 문자열로 큰수 다루기
    
        // 중복선택을 방지해야됨
    
        // 시간 초과 발생
        // X와 Y는 300만 자리수??
        // 만약에 0이 300만개 짜리라고 치면??
    
        //StringBuilder 써야되는듯?
    

        public string solution(string X, string Y)
        {
            StringBuilder sb = new StringBuilder();
            int[] arrayX = new int[10];
            int[] arrayY = new int[10];
            
            foreach (char x in X)
            {
                arrayX[int.Parse(x.ToString())]++;
            }
            
            foreach (char y in Y)
            {
                arrayY[int.Parse(y.ToString())]++;
            }
            
            for(int i =0; i< 10; i++)
            {
                int min = Math.Min(arrayX[i], arrayY[i]);
                
                for (int j =0; j< min; j++)
                {
                    sb.Append(i);
                }
            }

            char[] temp = sb.ToString().ToCharArray();
            Array.Sort(temp);
            Array.Reverse(temp);
            string answer = new string(temp);

            return answer.Length == 0 ? "-1" : answer[0] == '0' ? "0" : answer;

        }

    }