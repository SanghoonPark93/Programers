using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    //다른 사람의 풀이 https://programmers.co.kr/learn/courses/30/lessons/77484/solution_groups?language=csharp
    public int[] solution(int[] lottos, int[] win_nums)
    {
        var answer = new List<int>();

        var unknowability = 0;
        var count = 0;
        foreach(var num in lottos) 
        {
            if(num == 0)
            { 
                ++unknowability;
                continue;
            }

            if(win_nums.Contains(num) == true)
                ++count;
        }

        answer.Add(GetGrade(count + unknowability));
        answer.Add(GetGrade(count));

        return answer.ToArray();
    }

    private int GetGrade(int count) 
    {
        return Math.Min(6 - count + 1, 6);
    }
}