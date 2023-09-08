using System;
using System.Collections.Generic;

public class Solution {
    // n을 가지고 n행 n열의 2차원 배열을 만들고 n+1로 만들어야겠네
    // 인덱스를 1~n까지 채운다
    
    // 그런데
    // 123
    // 223
    // 333
    
    // 아마 (10^7)^2 배열을 만들지 못해서 발생하는 문제가 아닐까 생각함
    
    // 구간을 미리 제한해서 배열을 만들어야겠지?
    
    // 1차원 배열 상태에서의 left ~ right 구간을 미리 계산할려면
    
    // left / n = 몇번째 열인지 찾는다. 0 일때 1열
    // left % n = 몇번쨰 행인지 찾는다. 0 일때 1행
    // right / n = 몇번째 열인지 찾는다.
    // right % n = 몇번째 행인지 찾는다.
    
    // 그리고 2차원 배열 -> 1차원 배열로 만드는 과정을 하지않고
    // 바로 1차원 배열로 만들어준다
    
    public long[] solution(int n, long left, long right) 
    { 
        return MakeArray(n, left, right);
    }
    
    public long[] MakeArray(long n, long left, long right)
    {
        List<long> rank1List = new List<long>();
        
        long startColumn = left/ n + 1;
        long startRow = left % n + 1;
        
        long endColumn = right/ n + 1;
        long endRow = right % n + 1;
        
        // 시작열 중간열 끝열을 나누어준다.
        
        // 만약에 시작과 끝열이 같다면?
        
        if (startColumn < endColumn)
        {
            for (long i = startRow; i <= n; i++)
            {
                rank1List.Add(i > startColumn ? i : startColumn);
            }
        
        
            for(long i =startColumn+1; i< endColumn; i++)
            {
                for(long j=1; j <= n; j++)
                {
                    rank1List.Add(j > i ? j : i );
                }
            }
        
            for (long i =1 ; i<= endRow; i++)
            {
                rank1List.Add(i > endColumn ? i : endColumn);
            }    
        }
        else
        {
            // 만약에 시작과 끝열이 같다면?
            
            for (long i= startRow; i<= endRow; i++)
            {
                rank1List.Add(i > startColumn ? i : startColumn);
            }
        }
        
        
        return rank1List.ToArray();
    }    
    
}

/*
using System;
using System.Collections.Generic;

public class Solution {
    // n을 가지고 n행 n열의 2차원 배열을 만들고 n+1로 만들어야겠네
    // 인덱스를 1~n까지 채운다
    
    // 그런데
    // 123
    // 223
    // 333
    
    // 런타임 에러 발생
    
    // 아마 (10^7)^2 배열을 만들지 못해서 발생하는 문제가 아닐까 생각함
    public int[] solution(int n, long left, long right) 
    {
 
        int[,] rank2Array = MakeRank2Array(n);
        int[] rank1Array = Rank2ToRank1(rank2Array);
        int[] answer = ArraySplit(left,right,rank1Array);
        
        return answer;
 
        return ArraySplit(left,right,Rank2ToRank1(MakeRank2Array(n)));
    }
    
    public int[,] MakeRank2Array(int n)
    {
        int[,] rank2Array = new int[n+1,n+1];
        
        for(int i =1; i< n+1; i++)
        {
            for(int j=1; j < n+1; j++)
            {
                rank2Array[i,j] = j > i ? j : i ;
            }
        }
        
        return rank2Array;
    }
    
    public int[] Rank2ToRank1(int[,] rank2Array)
    {
        List<int> rank1List = new List<int>();
         
        for(int i =1; i< rank2Array.GetLength(0); i++)
        {
            for(int j = 1; j< rank2Array.GetLength(1); j++)
            {
                rank1List.Add(rank2Array[i,j]);
            }
        }
        return rank1List.ToArray();
    }
    
    public int[] ArraySplit(long left, long right, int[] rank1Array)
    {
        List<int> answer = new List<int>();
        
        for (long i= left; i<= right; i++)
        {
            answer.Add(rank1Array[i]);
        }
              
        return answer.ToArray();
    }
    
    
}
*/