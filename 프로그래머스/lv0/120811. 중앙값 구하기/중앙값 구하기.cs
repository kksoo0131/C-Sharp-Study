using System;
using System.Linq;

public class Solution {
    public int solution(int[] array) {
        return array.OrderBy(x => x).ToArray()[array.Length/2];
    }
}