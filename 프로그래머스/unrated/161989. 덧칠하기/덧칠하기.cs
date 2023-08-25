using System;

public class Solution
    {
        // n 미터의 벽을 1m 마다 섹션을 나눈다
        // 한번에 m미터의 벽을 칠한다.
        // 벽을 칠할때 시작점 ~ 시작점+m 까지 한번에 칠해진다.
        // 페인트 칠을 해야하는 최소횟수는?

        public int solution(int n, int m, int[] section)
        {
            // 1~n번까지 번호를 붙혔으므로 0은 버리자
            // 한번에 m을 칠하기 때문에 +m으로 여유공간 생성
            bool[] wall = new bool[n + 1 + m];
            int count = 0;

            foreach (int i in section)
            {
                wall[i] = true;
            }

            // 칠해야하는 부분들이 wall배열에서 true로 표시되어있음

            for (int i = section[0]; i <= section[section.Length-1]; i++)
            {
                if (wall[i])
                {
                    for (int j = 0; j < m; j++)
                    {
                        wall[i + j] = false;
                    }
                    count++;
                }
            }

            return count;
        }
    }