using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer =0;
        // 대진표를 한층씩 올라가서 만난다.
        // a = b 라는 말은 그전 대진에서 a와 b가 만났다는 뜻.
        while ( a != b){
            a = a/2 + a%2;
            b = b/2 + b%2;
            answer++;
        }
        
        return answer;
    }
}