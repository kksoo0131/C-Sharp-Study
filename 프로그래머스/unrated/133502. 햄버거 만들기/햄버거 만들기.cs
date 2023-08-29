using System;
using System.Collections.Generic;

public class Solution {
    // stack 문제인가?
    
    // stack을 계속해서 채우다가
    // 스택의 마지막 4개를 확인해서 pop
    
    // 빵 1, 야채 2, 고기 3 => pop했을때 1 3 2 1이 나와야함
    Stack<int> hamburger = new Stack<int>();
    int answer = 0;
    public int solution(int[] ingredient) 
    {    
        foreach(int i in ingredient)
        {
            
            // 햄버거의 길이가 3이상이고 이번 i가 1이라면 햄버거 체크 시작
            // 321이 나오면 햄버거니까 i를 넣지않고 
            if(hamburger.Count >= 3 && i == 1 && CheckBurger())
            {
                answer++;
            }
            else
            {
                hamburger.Push(i);    
            }
            
        }
        
        return answer;
    }
    
    public bool CheckBurger()
    {
        int count =3;
        Stack<int> temp = new Stack<int>();
        
        while(count > 0)
        {
            int pop = hamburger.Pop();
            
            if (pop == count)
            {
                count--;
                temp.Push(pop);
            }
            else
            {
                hamburger.Push(pop);
                count = 0;
                while (temp.Count > 0)
                {
                    hamburger.Push(temp.Pop());
                }
                return false;
            }
        }
        
        return true;    
    }
}