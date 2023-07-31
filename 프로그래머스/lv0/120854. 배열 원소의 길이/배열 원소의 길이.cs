using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] strlist) {
        Queue<int> answer = new Queue<int>();
        
        foreach(string str in strlist){
            answer.Enqueue(str.Length);
        }
        return answer.ToArray();
    }
}