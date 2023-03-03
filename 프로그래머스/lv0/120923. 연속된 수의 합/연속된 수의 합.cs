using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int num, int total) {
        List<int> answer = new List<int>();
        int middle = total/num;
        answer.Add(middle);
        total -= answer[0];
        // middle 구하고
        // 1. middle로 나누어 떨어지는경우
        // 남은 바퀴를 돌면서 answer에 두개씩 더해준다.
        // 2. 나누어 떨어지지 않는경우
        // 남은수가 middle x2 보다 크거나 같으면 처리하고
        // 아니면 남은걸 answer에 넣고 끝
        
        // 위아래 같이 처리해야됨
        for (int i=1; i<= (num-1)/2; i++){
            if (total - 2*middle >= 0){
                answer.Add(middle -i);
                answer.Add(middle +i);
                total -= (middle *2);
            }
        }
        if (total != 0)
            answer.Add(total);
        
        answer.Sort(); 
        return answer.ToArray();
    }
}