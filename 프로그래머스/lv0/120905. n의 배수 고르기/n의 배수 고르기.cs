using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        List<int> answer = new List<int>();
        
        foreach(int i in numlist){
            if (i % n == 0){
                answer.Add(i);
            }
            
        }
        return answer.ToArray();
    }
}