using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[,] sizes) {
        // 모든 명함을 수납하기 위한 지갑의 크기를 구하여라
        // 단 , 명함의 가로와 세로는 교환이 가능하여 둘중 하나만 만족해도된다.
        
        
        // DP인거 같은데?
        // dp[0] = 60 , 50 , 3000
        // dp[1] = 30, 70으로 넣으려면 60, 70 , 4200 || 70, 30으로 넣으려면 70, 50 , 3500
        // dp[2] = 60, 30으로 그냥 넣을수있음 3500
        // dp[3] = 80,40 으로 넣으려면 80 70 5600 || 80 50 4000
        
        List<int[]> dp = new List<int[]>();
        dp.Add(new int[]{sizes[0,0], sizes[0,1]});
        
        for(int i = 1; i < sizes.GetLength(0); i++)
        {
            int[] temp1 = new int[] {Math.Max(dp[i-1][0], sizes[i,0]), Math.Max(dp[i-1][1], sizes[i,1]) } ;
            int[] temp2 = new int[] {Math.Max(dp[i-1][0], sizes[i,1]), Math.Max(dp[i-1][1], sizes[i,0]) } ;
            
            dp.Add(temp1[0] * temp1[1] > temp2[0] * temp2[1] ? temp2 : temp1);
            
        }
        
        return dp[dp.Count-1][0] * dp[dp.Count-1][1];
    }
}