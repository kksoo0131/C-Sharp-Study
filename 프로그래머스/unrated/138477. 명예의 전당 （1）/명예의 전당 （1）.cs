using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int k, int[] score) 
    {
        // 저번 명전 리스트 + 이번값 해서 3개만 저장
        List<int> list = new List<int>();
        int[] answer = new int[score.Length];
        
        // k가 score보다 긴 경우를 방지
        if (k > score.Length)
        { 
            k = score.Length;
        }
        
        // k일까지는 전부 명전에 오름
        for(int i=0; i< k; i++)
        {
            list.Add(score[i]);
            list.Sort();
            answer[i] = list[0];
        }
        
        // k일 이후에는
        for(int i = k; i< score.Length; i++)
        {
            // 오늘의 점수가 최소값보다 크다면 리스트를 갱신
            if (score[i] > list[0])
            {
                list.RemoveAt(0);
                list.Add(score[i]);
                list.Sort();
            }
            
            // 오늘의 점수 발표
            answer[i] = list[0];  
        }
     
        return answer;
    }
}

/* 
테스트 케이스 9번 11번에서 오류 발생

이유는 k의 길이가 score의 길이보다 긴 경우에 발생한다.

public class Solution 
{
    public int[] solution(int k, int[] score) 
    
        // 저번 명전 리스트 + 이번값 해서 3개만 저장
        List<int> list = new List<int>();
        int[] answer = new int[score.Length];
        
        // k일까지는 전부 명전에 오름
        for(int i=0; i< k; i++)
        {
            list.Add(score[i]);
            list.Sort();
            answer[i] = list[0];
        }
        
        // k일 이후에는
        for(int i = k; i< score.Length; i++)
        {
            // 오늘의 점수가 최소값보다 크다면 리스트를 갱신
            if (score[i] > list[0])
            {
                list.RemoveAt(0);
                list.Add(score[i]);
                list.Sort();
            }
            
            // 오늘의 점수 발표
            answer[i] = list[0];  
        }
     
        return answer;
    }
}
*/