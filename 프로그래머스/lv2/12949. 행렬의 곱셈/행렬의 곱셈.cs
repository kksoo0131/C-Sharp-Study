using System;

public class Solution {
    // 행과 열의 길이가 각각 100이상 100 이하
    
    // 실패 or 런타임 에러 ,, 0점
    // 왜지? 배열 크기가 잘못됬나?
    
    // arr2 [k, j]는
    
    // 모든 arr1 [i,j]에 더해진다?
    public int[,] solution(int[,] arr1, int[,] arr2) 
    {
        int[,] answer = new int[arr1.GetLength(0),arr2.GetLength(1)];
        
        // arr1의 1차원 접근 i
        for(int i = 0 ; i< arr1.GetLength(0); i++)
        {        
            // arr2의 2차원 접근
            for(int j = 0; j < arr2.GetLength(1); j++)
            {
                // arr1의 2차원 접근, arr2의 1차원 접근
                for(int k =0; k < arr1.GetLength(1); k++)
                {
                    answer[i,j] += arr1[i,k] * arr2[k, j];
                }
            }
            
    
            
        }
           
        return answer;
    }
}