using System;

public class Solution {
    public int solution(int chicken) {
        int answer = 0;
        int temp = 0;

        while (chicken > 0){
            answer += (chicken / 10);
            temp += chicken %10;
            chicken /= 10;
            
            if (temp / 10 >= 1){
                chicken += temp/10;
                answer += temp/10;
                temp = temp %10;
            }
            Console.WriteLine ($"chicken : {chicken}, temp : {temp}, answer : {answer}");
            
            }
        
        
        
        
        
        return answer;
    }
}