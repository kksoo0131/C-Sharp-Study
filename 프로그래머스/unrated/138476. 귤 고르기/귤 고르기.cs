using System;

public class Solution {
    // 귤을 크기별로 분류하고
    // 한 상자에 귤의 종류가 최소가 되도록 담는다
    
    // 배열에 index == 귤의크기 value == 갯수로 배열을 만든다.
    // 배열을 정렬해서 종류가 많은 귤부터 상자에 담는다.
    public int solution(int k, int[] tangerine) 
    {
        int[] classify = new int[10000001];
        int answer =0;
        foreach(int i in tangerine)
        {
            classify[i]++;
        }
        
        Array.Sort(classify);
        Array.Reverse(classify);
        
        foreach(int i in classify)
        {
            k -= i;
            answer++;
            
            if(k <= 0)
            {
                break;
            }
            
        }
        
        return answer;
    }
}