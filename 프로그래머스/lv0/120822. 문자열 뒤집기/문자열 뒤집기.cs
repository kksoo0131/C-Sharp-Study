using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
        Stack<char> stack = new Stack<char>();

        foreach (char c in my_string)
        {
			stack.Push(c);
        }
        
        while(stack.Count != 0){
            answer += stack.Pop();
        }

        return answer;
    }
}