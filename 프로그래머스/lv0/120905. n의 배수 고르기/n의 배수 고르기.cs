using System;
using System.Linq;

public class Solution {
    public int[] solution(int n, int[] numlist) {
        // Where은 조건을 만족하는 데이터를 가져오고
        // Select는 람다의 결과를 가져온다.
        return  numlist.Where ( x => x % n == 0 ).ToArray();        
    }
}