using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n) {
        Queue<int> answer = new Queue<int>();
        
        for (int i = 1; i<= n ; i+=2 ){
            answer.Enqueue(i);
        }
        
        return answer.ToArray();
    }
}