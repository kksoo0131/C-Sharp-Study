using System;
using System.Text;
using System.Collections.Generic;

public class Solution {
    public string solution(int[] numbers) {
        
        StringBuilder sb = new StringBuilder();
        Array.Sort(numbers, new SolveCompare());
        
        if (numbers[0] == 0) return "0"; // 전부다 0일때
        
        foreach(int i in numbers)
        {
            sb.Append(i);
        }
        
        return sb.ToString();
        //return string.Join("", numbers);
    }
}

public class SolveCompare : IComparer<int>
{
    public int Compare(int a, int b)
    {
        string strA = a.ToString();
        string strB = b.ToString();
        
        return string.Compare(strB + strA, strA + strB);
    }
}
