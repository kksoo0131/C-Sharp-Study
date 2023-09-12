using System;
using System.Collections.Generic;

public class Solution {
    // 길이체크를 앞에서 하면 안되는 이유
    
    // 만약 이번 선택을 하고나면 남은 모든 던전은 갈수 없을때
    
    // 길이체크를 앞에서하게되면  num이 업데이트 되지않아서 num을 업데이트 하지않고 함수가 종료됨
    
    // 원래 처음에 길이체크를 앞에서 한 이유는 인덱스 범위를 벗어날까봐였는데
    
    // 생각해보니 반복문을 통해서 인덱스의 길이를 한번체크하기때문에 그렇게할 필요가없었다.
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

/*
using System;
using System.Collections.Generic;

public class Solution {
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
        
       
        
    }
}
*/