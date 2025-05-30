// Include namespace system
using System;
using System.Collections.Generic;
public class Solution
{
    public int solution(int[] A)
    {
        var peaksIndexList = new List<int>();
        for (int i = 1; i < A.Length - 1; i++)
        {
            if (A[i - 1] < A[i] && A[i] > A[i + 1])
            {
                peaksIndexList.add(i);
            }
        }
        var N = A.Length;
        for (int numBlocks = N; numBlocks >= 1; numBlocks--)
        {
            if (N % numBlocks == 0)
            {
                var blockSize = (int)(N / numBlocks);
                var ithOkBlock = 0;
                foreach (var peaksIndex in peaksIndexList)
                {
                    if ((int)(peaksIndex / blockSize) == ithOkBlock)
                    {
                        ithOkBlock++;
                    }
                }
                if (ithOkBlock == numBlocks)
                {
                    return numBlocks;
                }
            }
        }
        return 0;
    }
}