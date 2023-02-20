https://school.programmers.co.kr/learn/courses/30/lessons/159994

```cs
using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int c1count = 0;
        int c2count = 0;

        foreach (string word in goal)
        {
            if (c1count < cards1.Length && cards1[c1count] == word)
            {
                c1count += 1;
            }
            else if (c2count < cards2.Length &&cards2[c2count] == word)
            {
                c2count += 1;
            }
            else        
                return "No";
        }
        return "Yes";
    }
}
```
