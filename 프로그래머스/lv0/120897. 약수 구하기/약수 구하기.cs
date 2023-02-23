using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        List<int> answer = new List<int>();    
        
        for (int i =0 ; i <n; i++){
            if(n % (i+1) == 0){
                answer.Add(i+1);
            }
        }
       
        return answer.ToArray();
    }
}