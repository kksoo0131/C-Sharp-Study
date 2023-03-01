using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        foreach(int i in array){
            answer += i.ToString().Count(x => x.ToString() == "7");
        }
        return answer;
    }
}