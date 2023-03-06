<h1>탐색 </h1>

많은 양의 데이터 중에서 "원하는 데이터를 찾는 과정"을 의미한다.
대표적인 탐색 알고리즘으로 DFS와 BFS를 꼽을수있다.

<h2>그래프</h2>

노드와 간선으로 표현되며 그래프 탐색이란 하나의 노드를 시작으로 다수의 노드를 방문하는 것을 말한다. 

또 두 노드가 간선으로 연결되어 있다면 두 노드는 인접하다라고 표현한다.

프로그래밍에서 그래프는 크게 2가지 방식으로 표현할 수 있다.

1. 인접 행렬 : 2차원 배열로 그래프의 연결 관계를 표현   

3. 인접 리스트 : 리스트로 그래프의 연결관계를 표현하는 방식

인접 행렬 방식은 모든 관계를 저장하므로 노드 개수가 많을수록 "메모리가 불필요하게 낭비"되지만 "속도가 빠르고"

인접 리스트 방식은 연결된 정보만을 저장하기 때문에 "메모리를 효율적으로 사용"한다. 대신 연결된 데이터를 하나씩 확인해야 하기때문에 "속도가 느리다".


<h2> DFS (Depth-First Search)</h2>

깊이 우선 탐색이라고도 부르며, 그래프에서 깊은 부분을 우선적으로 탐색하는 알고리즘, O(N)의 시간복잡도를 가진다.
스택이나 재귀 함수를 이용해 구현 할 수 있다.


<h4>동작 과정</h4>

1. 탐색 시작 노드를 스택에 삽입하고 방문 처리를 한다.
2. 스택의 최상단 노드에 방문하지 않은 인접 노드가 있으면 그 인접 노드를 스택에 넣고 방문처리를 한다. (없다면 스택에서 최상단 노드를 꺼낸다.)
3. 2번의 과정을 반복한다.

```cs
using System;
using System.Collections.Generic;

class Program
{
    static void dfs(List<List<int>> graph, int v, List<bool> visited)
    {
        visited[v] = true;
        Console.WriteLine($"{v} ");

        foreach (int i in graph[v])
        {
            if (visited[i] == false)
                dfs(graph, i, visited);
        }
    }

    public static void Main(string[] args)
    {
        List<List<int>> graph = new List<List<int>>()
        {
            new List<int> { },
            new List<int> { 2,3,8},
            new List<int> { 1, 7},
            new List<int> { 1,4,5},
            new List<int> { 3,5},
            new List<int> { 3,4},
            new List<int> { 7},
            new List<int> { 2,6,8},
            new List<int> { 1,7}
        };

        List<bool> visited = new List<bool>();
        for (int i = 0; i < 9; i++)
        {
            visited.Add(false);
        }

        dfs(graph, 1, visited);
    }
}

```


<h2> BFS (Breadth First Search)</h2>

너비 우선 탐색이라는 의미로 가까운 노드부터 탐색하는 알고리즘이다.
선입선출 방식인 큐 자료구조를 이용하는게 정석으로, 인접한 노드를 반복적으로 큐에 넣는다. O(N)의 시간복잡도.



<h4>동작 과정</h4>

1. 탐색 시작 노드를 큐에 삽입하고 방문 처리를 한다.
2. 큐에서 노드를 꺼내 해당 노드의 인접 노드 중에서 방문하지 않은 노드를 모두 큐에 삽입하고 방문처리를 한다.
3. 2번의 과정을 반복한다.


```cs

using System;
using System.Collections.Generic;

class Program
{
    static void bfs(List<List<int>> graph, int v, List<bool> visited)
    {
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(v);
        visited[v] = true;

        while (queue.Count > 0)
        {
            v = queue.Dequeue();
            Console.WriteLine($"{v}");

            foreach (int i in graph[v])
            {
                if (visited[i] == false)
                {
                    queue.Enqueue(i);
                    visited[i] = true;
                }
            }
        }
    }

    public static void Main(string[] args)
    {
        List<List<int>> graph = new List<List<int>>()
        {
            new List<int> { },
            new List<int> { 2,3,8},
            new List<int> { 1, 7},
            new List<int> { 1,4,5},
            new List<int> { 3,5},
            new List<int> { 3,4},
            new List<int> { 7},
            new List<int> { 2,6,8},
            new List<int> { 1,7}
        };

        List<bool> visited = new List<bool>();
        for (int i = 0; i < 9; i++)
        {
            visited.Add(false);
        }

        bfs(graph, 1, visited);
    }
}
```
