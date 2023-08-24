using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        List<int> list = new List<int>();
        
        foreach(int i in arr){
            if (i % divisor == 0){
                list.Add(i);
            }
        }
        list.Distinct();
        list.Sort();
        return list.Count == 0 ? new int[] {-1} : list.ToArray();
    }
}