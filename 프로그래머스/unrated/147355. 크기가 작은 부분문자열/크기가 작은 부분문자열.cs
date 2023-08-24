using System;

public class Solution {
    public int solution(string t, string p) {
        // 숫자 문자열 t에서
        // p와 길이가 같고 p보다 작거나 같은것의 횟수를 구해라.
        // 시작점 ~ 길이
        
        // ?? p의 최대길이가 18
        // 그러면 10의 18승?? -> 문자열로 비교해야됨
        
        
        int answer = 0;
        int length = p.Length;
        
        for(int i = 0; i<= t.Length - length; i++)
        {
            
            answer += CompareNumString(p, t.Substring(i, length)) ? 1 : 0;
            
        }
        
        return answer;
    }
    
    public bool CompareNumString(string a, string b)
    {
        for(int i =0; i< a.Length; i++)
        {   
            if(a[i] < b[i])
            {
              return false;  
            } 
            else if(a[i] > b[i])
            {
              return true;                  
            } 
        }  
        return true;
    }
}