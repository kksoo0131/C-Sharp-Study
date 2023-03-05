using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] number) {
        List <int> list = number.ToList();
        int answer = 0;
        
        int temp = 0;
        while (list.Count != 0){
            temp = list[0];
            list.RemoveAt(0);
            for(int i =0; i < list.Count; i++){
                for (int j= i+1; j <list.Count; j++ ){
                    if(temp + list[i] +list[j] == 0)
                        answer += 1;
                }
            }
        }
        return answer;
    }
}