using System;
using System.Collections.Generic;

public class Solution {
    public Queue<int> solution(int[] numbers) {
        Queue<int> answer = new Queue<int>();
        
        foreach(int n in numbers){
            answer.Enqueue(n*2);
        }
        return answer;
    }
}