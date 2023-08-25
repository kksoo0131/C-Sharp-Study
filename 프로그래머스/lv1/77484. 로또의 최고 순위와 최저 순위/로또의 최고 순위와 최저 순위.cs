using System;
using System.Linq;

public class Solution
    {
        // 알아볼 수 없는 번호를 0으로 표기
        // 일단 최저 갯수를 계산하고 최고 순위는 최저갯수 + 0의 갯수
        public int[] solution(int[] lottos, int[] win_nums)
        {
            int zeroNum = 0;
            int count = 0;
            foreach (int num in lottos)
            {
                if (num == 0) 
                {
                    zeroNum++; 
                    continue;
                }
                
                count += win_nums.Contains(num) ? 1 : 0;
            }
            
            int[] answer = new int[2];
            
            answer[1] = count < 2 ? 6 : count < 3 ? 5 : count < 4 ? 4 :count < 5 ? 3 : count < 6 ? 2 : 1;
            count += zeroNum;
            answer[0] = count < 2 ? 6 : count < 3 ? 5 : count < 4 ? 4 :count < 5 ? 3 : count < 6 ? 2 : 1;
            
            return answer;
        }
    }