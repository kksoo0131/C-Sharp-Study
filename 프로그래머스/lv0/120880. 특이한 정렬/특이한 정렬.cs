using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numlist, int n) {
        List <int> list = numlist.ToList();
        List <int> answer = new List<int>();
        
        while(answer.Count() != list.Count()){
            int temp = 10000;
            int check = 0;
            for (int i=0; i<list.Count(); i++){
                
                if (answer.Exists(x => x == list[i]))
                    continue;

                if (Math.Abs(list[i]-n) <temp){
                    temp = Math.Abs(list[i]-n);
                    check = list[i];
                }
                else if (Math.Abs(list[i]-n) == temp){
                    check = Math.Max(check,list[i]);
                }
            }
            answer.Add(check);   
        }

        return answer.ToArray();
    }
}