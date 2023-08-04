using System;

public class Solution {
    public int solution(int[] array) {
        Array.Sort(array);
        
        return array[array.Length/2];
    }
}