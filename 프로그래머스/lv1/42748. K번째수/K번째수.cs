using System;

public class Solution
{
    public int[] solution(int[] array, int[,] commands)
    {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int start = commands[i, 0] - 1;
            int end = commands[i, 1] - 1;
            int length = end - start + 1;

            int[] temp = new int[length];

            Array.ConstrainedCopy(array, start, temp, 0, length);

            Array.Sort(temp);
            answer[i] = temp[commands[i, 2] - 1];
        }

        return answer;
    }
}