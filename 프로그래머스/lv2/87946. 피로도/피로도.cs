using System;
using System.Collections.Generic;

public class Solution {
    // 최소 피로도, 소모 피로도
    // 던전 리스트를 순회하면서 탐험할 수 있는 최대 던전수를 return
    
    // 던전 탐험의 순서에 따라서 결과가 달라진다.
    
    // 최소 피로도가 크고 소모 피로도가 작을수록 우선순위가 높아야함
    
    // 던전의 개수는 8이하임 모든 순서를 고려해도 될듯?
    
    
    // n개의 던전에서 최소 피로도가 k보다 낮은 던전중 하나를 선택해서 탐험.
    
    // 재귀, 필요한것 1. 현재 피로도, 2. 남은 던전 리스트, 3. 탐험한 던전의 수
    
    // 최소피로도를 만족못하는것들은 버림
    
    int answer = 0;
    public int solution(int k, int[,] dungeons) 
    {   
        Queue<int[]> queue = new Queue<int[]>();
        
        for(int i =0; i< dungeons.GetLength(0); i++)
        {
            queue.Enqueue(new int[]{dungeons[i,0], dungeons[i,1]});
        }
        
        RecursiveDungeon(0, k, queue);
        
        return answer;
        
    }
    
    public void RecursiveDungeon(int num,int k, Queue<int[]> queue)
    {
        Queue<int[]> tempQueue = new Queue<int[]>();
        
        // queue를 깊은복사.
        foreach (int[] arr in queue)
        {
            tempQueue.Enqueue(arr);
        }
        
        // 길이가 0이라면 끝
        if(tempQueue.Count == 0)
        {
            answer = Math.Max(answer, num);
            return;
        }
        
        int length = tempQueue.Count;
        
        // queue의 요소 갯수만큼 반복
        // 다음 재귀에는 각각의 요소를 선택하고 남은 큐를 복사해서 사용하게됨
        for(int i =0; i <length; i++)
        {
            int[] temp = tempQueue.Dequeue();
            
            if(temp[0] <= k)
            {
                RecursiveDungeon(num+1, k-temp[1], tempQueue);
                tempQueue.Enqueue(temp);
            }
        }
        
               // 길이가 0이라면 끝
        if(tempQueue.Count == 0)
        {
            answer = Math.Max(answer, num);
            return;
        }
        
    }
}