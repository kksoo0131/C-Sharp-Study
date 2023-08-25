using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        // 각자의 시험지가 있고
        // 답지 answer가 주어질때
        // 가장 높은 점수를 가진 사람들을 배열(오름차순)으로 리턴
        
        // 사람은 저 3명인건가?
        
        int[] score = new int[3];
        int[][] student = new int[3][];
        student[0] = new int[]{1,2,3,4,5};
        student[1] = new int[]{2,1,2,3,2,4,2,5};
        student[2] = new int[]{3,3,1,1,2,2,4,4,5,5};
        
        for(int i =0; i< 3; i++)
        {
            int index = 0;
            foreach(int ansNum in answers)
            {
                score[i] += student[i][index++] == ansNum ? 1 : 0;
                
                if (index >= student[i].Length)
                {
                    index = 0;
                }
            }
        }

        // 배열에 3명의 점수가 담겨있음
        int max = score.Max();
        List<int> answer = new List<int>();
        
        for(int i =0; i< score.Length; i++)
        {
            if (score[i] == max)
            {
                answer.Add(i+1);
            }
        }
        
        return answer.ToArray();
    }
}