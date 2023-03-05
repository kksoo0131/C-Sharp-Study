using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[,] score) {
        int lastRanking = 1;
        int[] answer =Enumerable.Repeat(0,score.GetLength(0)).ToArray();
        
        for (int sum = 200;sum >= 0; sum-=1){
            
            List<int> temp = new List<int>();
            
            for (int i = 0; i < score.GetLength(0); i++){
                
                if(score[i,0] + score[i,1] == sum){
                    temp.Add(i);
                }
            }
            
            for (int i =0; i < temp.Count(); i++){
                answer[temp[i]] = lastRanking;
            }
            
            lastRanking += temp.Count();
        }
        return answer;
    }
}