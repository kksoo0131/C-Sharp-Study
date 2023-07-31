using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] num_list) {
        Stack<int> answer = new Stack<int>();
        
        foreach (int i in num_list){
            answer.Push(i);
        }
        

        return answer.ToArray();
    }
}