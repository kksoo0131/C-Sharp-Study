using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        for(int i=0; i < s.Length; i++){
            s = turn(s);
            answer += check(s);
        }
        
        return answer;
    }
    
    string turn (string s){
        char temp = s[0]; 
        s = s.Substring(1) + temp.ToString();
        return s;
    }

    int check (string s){
        int small = 0;
        int middle = 0;
        int large = 0;
        Stack<char> stack = new Stack<char>();
        //마지막으로 열린게 먼저 닫혀야한다.
        // 열린거 stack으로 관리해줘야됨
        
        foreach(char c in s){
            if (c == '(' || c == '{' || c == '[')
                stack.Push(c);
            else
            {
                if (stack.Count == 0)
                    return 0;
                
                char temp = stack.Peek();
                
                if (temp == '(' && c == ')')
                    stack.Pop();
                else if (temp == '{' && c == '}')
                    stack.Pop();
                else if (temp == '[' && c == ']')
                    stack.Pop();
                else
                    return 0;
                
            }
        }
        if (stack.Count != 0)
            return 0;
        return 1;
    }               
}
