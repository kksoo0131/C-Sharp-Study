using System;

class Solution
{
    //  n명이 토너먼트에 참가
    // 1~n번을 배정 받고 진출한 사람은 다시 1~N/2번을 배정받는다.
    // 게임은 최종 한명이 남을때 까지 진행된다.
    // A와 B가 주어질때 A와 B가 언제만날까?
    
    // 7 ,9, 27, 33 실패
    public int solution(int n, int a, int b)
    {
        int answer = 0;
        
        while ( a != b)
        {
            a = (a + 1) /2;
            b = (b + 1) /2;    
            answer++;
        }


        return answer;
    }
}

/*
class Solution
{
    //  n명이 토너먼트에 참가
    // 1~n번을 배정 받고 진출한 사람은 다시 1~N/2번을 배정받는다.
    // 게임은 최종 한명이 남을때 까지 진행된다.
    // A와 B가 주어질때 A와 B가 언제만날까?
    
    // 7 ,9, 27, 33 실패
    public int solution(int n, int a, int b)
    {
        int answer = 1;
        
        while ( Math.Abs(a-b) > 1)
        {
            a = (a + 1) /2;
            b = (b + 1) /2;    
            answer++;
        }


        return answer;
    }
}
*/