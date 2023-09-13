using System;
using System.Collections.Generic;

public class Solution {
    
    // numbers를 순회하면서
    
    // resultQueue에 더하거나 뺀값을 저장한다.
    
    // BFS
    public int solution(int[] numbers, int target) 
    {
        int answer =0;
        Queue<int> resultQueue = new Queue<int>();
        resultQueue.Enqueue(0);
        
        foreach(int number in numbers)
        {
            int count = resultQueue.Count;
            
            for(int i =0; i<count; i++)
            {
                int result = resultQueue.Dequeue();
                resultQueue.Enqueue(result - number);
                resultQueue.Enqueue(result + number);
            }

        }
        
        foreach(int i in resultQueue)
        {
            answer += i == target ? 1 : 0;
        }
        
        return answer;
    }
}