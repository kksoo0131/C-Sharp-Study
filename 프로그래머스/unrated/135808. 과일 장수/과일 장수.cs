using System;
using System.Collections.Generic;

public class Solution {
    // 사과는 1~k점
    // 한 상자에는 m개의 사과가들어감
    // 사과 한상자의 가격은 가장낮은점수 p * m
    
    // 최대한 많은 이익을 남겨라!
    
    // 높은 점수의 사과만 골라야됨
    public int solution(int k, int m, int[] score) 
    {        
        int answer = 0;
        int index = 0;
        int length = score.Length;
        int[] array;
        
        Array.Sort(score);       
        while(length >= m)
        {
            length -= m;
            array = new int[m];
            
            for(int i =0; i< m; i++)
            {
                array[i] = score[score.Length- 1 - (index++)];
                
            }
            answer += array[m-1] * m;           
        }
        return answer;
    }
}