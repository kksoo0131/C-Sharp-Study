using System;
using System.Collections.Generic;

public class Solution {
    // x칸 왼쪽으로 밀었을때 괄호문자열이 올바른가?
    
    // 왼쪽 괄호면 stack 에넣고
    // 오른쪽 괄호면 stack의 Peek 을 확인
    public int solution(string s) 
    {
        int answer = 0;
        
        for(int i =0; i< s.Length; i++)
        {
            answer += PushString(s,i) ? 1 : 0;
        }
        
        return answer;
    }
    
    public bool PushString(string s, int i)
    {
        string str = s.Substring(i, s.Length-i) + s.Substring(0, i);
        Stack<char> _stack = new Stack<char>();
        
        foreach(char c in str)
        {
            if (LeftString(c))
            {
                _stack.Push(c);
            }
            else if (_stack.Count != 0 && MatchString(_stack.Peek(), c))
            {
                _stack.Pop();
            }
            else
            {
                return false;
            }
            
        }
        
        // 남아있으면 올바르지않음
        
        
        return _stack.Count > 0 ? false :true;        
    }
    
    public bool LeftString(char a)
    {
        switch(a)
        {
            case '{':
                return true;
            case '[':
                return true;
            case '(':
                return true;
            default :
                return false;    
        }
        
    }
    
    public bool MatchString(char a, char b)
    {
        switch(a)
        {
            case '{':
                return b == '}' ? true : false;
            case '[':
                return b == ']' ? true : false;
            case '(':
                return b == ')' ? true : false;
            default :
                return false;    
        }
    }
}