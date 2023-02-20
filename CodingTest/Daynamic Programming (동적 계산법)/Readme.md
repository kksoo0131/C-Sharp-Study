<h1>다이나믹 프로그래밍</h1>

다이나믹 프로그래밍은 다음 조건을 만족할 때 사용할 수 있다.

1. 큰 문제를 작은 문제로 나눌 수 있다.
2. 작은 문제에서 구한 정답은 그것을 포함하는 큰 문제에서도 동일하다.

ex ) 피보나치 수열

<h2>Memoization</h2>

메모이제이션은 다이나믹 프로그래밍을 구현하는 방법 중 한 종류로, 

한번 구한 결과를 메모리 공간에 메모해두고 같은 식을 다시 호출하면 메모한 결과를 그대로 가져오는 기법이다.

값을 저장하는 방법이므로 "캐싱"이라고도 한다.

```cs
using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        int N = int.Parse(Console.ReadLine());
        int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

        // 창고가 n개 있을때의 최대 식량을 저장
        int[] dptable = Enumerable.Repeat(0, N).ToArray();

        // n-2가 점화식에 포함되기때문에 인덱스 0,1은 직접 입력하고 2부터 반복문 시작.
        dptable[0] = array[0];
        dptable[1] = Math.Max(array[0], array[1]);

        for (int i =2; i < N; i++)
        {
            dptable[i] = Math.Max(dptable[i - 1], dptable[i - 2] + array[i]);
        }

        Console.WriteLine($"{dptable[N-1]}");
    }  
}

```

위의 다이나믹 프로그래밍을 적용했을 때의 피보나치 수열 알고리즘의 시간 복잡도는 O(N)이다.

한 번 구한 결과는 다시 구하지 않기 때문이다. 위처럼 재귀 함수를 이용하여 다이나믹 프로그래밍 소스코드를 작성하는 방법을,

큰 문제를 해결하기 위해 작은 문제를 호출한다고 하여 "Top-Down 방식 (하향식)" 이라고 한다.

반면 단순히 반복문을 이용해 소스코드를 작성하는 경우 작은 문제부터 차근차근 답을 도출한다고 하여 "Bottom-Up 방식 (상향식)" 이라고 한다.

```cs
using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        decimal[] array = Enumerable.Repeat<decimal>(0, 100).ToArray();
        array[1] = 1;
        array[2] = 1;
        int n = 99;

        for (int i = 3; i < n+1; i++)
        {
            array[i] = array[i - 1] + array[i - 2];
        }
        Console.WriteLine($"{array[n]}");
    }
}
```


