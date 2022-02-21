using System.Collections.Generic;
using System.Linq;

public class Solution
{
    //다른 사람의 풀이 https://programmers.co.kr/learn/courses/30/lessons/92334/solution_groups?language=csharp
    public int[] solution(string[] id_list, string[] report, int k)
    {
        var reportCounting = new Dictionary<string, int>();
        var mailCounting = new Dictionary<string, int>();

        foreach(var id in id_list)
        {
            reportCounting.Add(id, 0);
            mailCounting.Add(id, 0);
        }

        var reportList = report.Distinct().ToList();
        foreach(var rep in reportList)
        {
            var splitArray = rep.Split(' ');
            var last = splitArray[1];
            ++reportCounting[last];
        }

        foreach(var rep in reportList)
        {
            var splitArray = rep.Split(' ');
            var first = splitArray[0];
            var last = splitArray[1];
            if(reportCounting[last] >= k)
                ++mailCounting[first];
        }

        return mailCounting.Values.ToArray();
    }
}