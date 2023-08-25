using System;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] food) {
        //데칼코마니? 같은 형태로 음식을 배치해야됨
        // food[0]는 항상 1이고 가운데 배치
        string answer = "";
        Stack<int> stack = new Stack<int>();
        
        
        for(int i =1; i < food.Length; i++)
        {
            while(food[i] > 1)
            {
                food[i] -=2;   
                answer += i;
                stack.Push(i);
            }    
        }
        answer += 0;
        
        while(stack.Count > 0){
            answer += stack.Pop();
        }
        
        return answer;
    }
}