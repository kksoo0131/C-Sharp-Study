using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        List<int> answer = new List<int>();
        int date =1;
        int release =0;
        Queue<int[]> queue = new Queue<int[]>();
        
        for(int i=0; i < progresses.Length; i++){
            queue.Enqueue(new int[]{progresses[i], speeds[i]});
        }
                 
        while(queue.Count > 0)
        {
            int[] temp = queue.Peek();
            
            if (temp[0] + temp[1] * date < 100){
                date++;
                continue;
            }
                
            
            answer.Add(0);
            while(temp[0] + temp[1] * date >= 100)
            { 
                answer[release] +=1;
                queue.Dequeue();
                if (queue.Count == 0)
                    break;
                temp = queue.Peek();
            }
            
            release++;
            
        }
        
        return answer.ToArray();
    }
}