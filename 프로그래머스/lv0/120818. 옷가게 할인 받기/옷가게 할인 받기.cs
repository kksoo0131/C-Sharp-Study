using System;

public class Solution {
    public int solution(int price) {
        
        if (price >= 500000){
            return (int)(price * 0.8f);
        }
        
        if (price >= 300000){
            return (int)(price * 0.9f);
        }
        
        if (price >= 100000){
            return (int)(price * 0.95f);
        }
        
        
        return price;
    }
}