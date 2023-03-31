using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string[] solution(string[,] plans) {
        List<string> answer = new List<string>();
        Dictionary<string, int[]> dic = new Dictionary<string, int[]>();
        Queue<string> queue = new Queue<string>();
        Stack<string> stack = new Stack<string>();
        
        for(int i=0; i<plans.GetLength(0); i++){
            int[] temp = Array.ConvertAll(plans[i,1].Split(":"), int.Parse);
            dic.Add(plans[i,0], new int[] {(temp[0] * 60 + temp[1]), int.Parse(plans[i,2])});
        }    
        dic = dic.OrderBy(x => x.Value[0]).ToDictionary(x => x.Key, x => x.Value);
        
        
        foreach(string s in dic.Keys){
            queue.Enqueue(s);
        }
        
        while(queue.Count > 1)
        {
            string now = queue.Dequeue();
            string next = queue.Peek();
            int time = dic[next][0] - dic[now][0];
            
            if(time >= dic[now][1])//이번 시간 안에 과제를 끝낼수 있는지
            {
                //끝낸 과제 추가
                answer.Add(now);
                time -= dic[now][1];
    
                
                // 남은 시간을 대기중인 과제에사용
                while(stack.Count >0 && time >0) //시간이 남았고, 대기중인 과제가 있다면
                {
                    string temp = stack.Pop();
                    
                    if(time >= dic[temp][1])// 시간안에 끝낼수 있는지
                    {
                        answer.Add(temp);
                        time -= dic[temp][1];
                    }
                    else
                    {
                        dic[temp][1] -= time;
                        time =0;
                        stack.Push(temp);
                    }
                    
                }
            }
            else
            {
                dic[now][1] -= time;
                stack.Push(now);
            }
      
        }
       
        answer.Add(queue.Dequeue());
        
        while(stack.Count>0){
            answer.Add(stack.Pop());
        }
        
 
        
        return answer.ToArray();
    }
}