using System.Collections.Generic;
public class Solution {
    public int[] solution(int[] arr) {
        int minIndex = 0;
        
        List<int> list = new List<int>();
        
        for(int i=0; i< arr.Length; i++){
            minIndex = arr[minIndex] > arr[i] ? i : minIndex;
            list.Add(arr[i]);
        }
        
        list.RemoveAt(minIndex);
        
        if(list.Count == 0 ){
            list.Add(-1);
        }
        
        return list.ToArray();
    }
}