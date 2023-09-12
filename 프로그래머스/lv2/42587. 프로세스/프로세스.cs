using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    // 큐에서 프로세스를 꺼내서 우선순위가 가장 큰지 확인
    // 이번 프로세스의 우선순위가 가장크다면 일단 실행 -> Max를 가지고있어야하나?
    // 인덱스도 같이 저장해야된다.
    public int solution(int[] priorities, int location) 
    {
        Queue<int[]> queue = new Queue<int[]>();
        
        for(int i =0; i  < priorities.Length; i++)
        {
            queue.Enqueue(new int[] {i, priorities[i]});
        }
        
        Array.Sort(priorities, (x,y) => y.CompareTo(x));
        int answer = 0;
        
        while(queue.Count >0)
        {  
            int[] temp = queue.Dequeue();
            
            if (temp[1] != priorities[answer])
            {
                queue.Enqueue(temp);
            }
            else
            {
                answer++;
                if (temp[0] == location)
                {
                    break;
                }
            }
        }
        
        return answer;
    }
}