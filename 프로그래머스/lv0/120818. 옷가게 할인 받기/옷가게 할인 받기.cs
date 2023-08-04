using System;

public class Solution {
    public int solution(int price) {
        
        /*
        float rate;
        if (price >= 500000){
            rate = 0.8f;
        }
        else if (price >= 300000){
            rate = 0.9f;
        }
        else if (price >= 100000){
            rate = 0.95f;
        }
        else{
            rate = 1.0f;
        }
        
        */
        float rate = price >= 500000 ? 0.8f : price >= 300000 ? 0.9f : price >= 100000 ? 0.95f : 1.0f;
        return (int)(price * rate);
    }
}