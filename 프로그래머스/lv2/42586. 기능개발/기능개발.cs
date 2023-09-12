using System;
using System.Collections.Generic;

public class Solution {
    // 턴 마다  progresses에 speed를 더해준다.
    // 앞에서 부터 배포가 가능한지 확인해서 배포한다.
    // 배포했다면 배포한 갯수를 answer에 저장한다.
    
    int[] progresses;
    int[] speeds;
    int index;
    List<int> answer = new List<int>();
    
    public int[] solution(int[] progresses, int[] speeds) 
    {
        this.progresses = progresses;
        this.speeds = speeds;
        index = 0;
        
        while (index < progresses.Length)
        {
            OneDateLater();
            Publish();
        }

        return answer.ToArray();
    }
    
    public void OneDateLater()
    {
        for(int i =index; i< progresses.Length; i++)
        {
            progresses[i] += speeds[i];
        }
    }
    
    public void Publish()
    {
        int completed = 0;
        
        while(index < progresses.Length &&  progresses[index] >= 100)
        {
            completed++;
            index++;
        }
        
        if(completed > 0)
        {
            answer.Add(completed);    
        }
    
    }
}