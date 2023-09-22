using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    
    // Dictionary에 차량 번호와 입차 시간을 저장한다
    
    // 시간은 분으로 환산해서 저장하자
    
    // 출차 기록이 들어올시 Dictionary에서
    
    // 차량 번호 주차 요금을 계산해서 결과 Dictionary에 저장하고
    
    // 차량번호가 작은순으로 Dictionary를 정렬해서 요금을 return;
    
    // 같은 차가 여러번 In 될수 있음
    public int[] solution(int[] fees, string[] records) {
        Dictionary<int, int> dic = new Dictionary<int,int>();
        Dictionary<int, int> result = new Dictionary<int,int>();
        List<int> answer = new List<int> ();
        
        foreach(string record in records)
        {
            string[] temp = record.Split(" ");
            int time = int.Parse(temp[0].Substring(0,2) )* 60;
            time += int.Parse(temp[0].Substring(3,2));
            
            int key = int.Parse(temp[1]);
            if (temp[2] == "IN")
            {
                dic.Add(key, time);
            }
            else
            {
                if(result.ContainsKey(key))
                {
                    result[key] += (time - dic[key]);
                }
                else
                {
                    result.Add(key, time - dic[key]);    
                }
                dic.Remove(key);
            }
        }
        
        // 출차시간이 없는 경우를 계산
        int lasttime = 23 * 60 + 59;
        foreach(KeyValuePair<int, int> record in dic)
        {
            int key = record.Key;
            if(result.ContainsKey(key))
                {
                    result[key] += (lasttime - record.Value);
                }
                else
                {
                    result.Add(key, lasttime - record.Value);
                }
        }
        
        // Dictioanry를 Key순으로 정렬
        List<int> keyList = result.Keys.ToList();
        keyList.Sort();
        
        foreach (int key in keyList)
        {
            int duration = result[key] - fees[0];
            float FaddRate = duration> 0 ? (float) duration / fees[2] : 0;
            int IaddRate = (int)FaddRate;
            
            IaddRate += FaddRate != IaddRate ? 1 : 0;
            int addFee = IaddRate * fees[3];
            int fee = fees[1] + addFee;
            answer.Add(fee);
        }
        return answer.ToArray();
    }
}