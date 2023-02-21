using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = numbers.Select(x => x * 2).ToArray(); return answer;
    }
}