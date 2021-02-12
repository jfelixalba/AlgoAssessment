using System;
using System.Collections.Generic;

namespace TGS.Challenge
{
  /*
       Given a zero-based integer array of length N, the equivalence index (i) is the index where the sum of all the items to the left of the index
       are equal to the sum of all the items to the right of the index.

       Constraints: 0 <= N <= 100 000

       Example: Given the following array [1, 2, 3, 4, 5, 7, 8, 10, 12]
       Your program should output "6" because 1 + 2 + 3 + 4 + 5 + 7 = 10 + 12

       If no index exists then output -1

       There are accompanying unit tests for this exercise, ensure all tests pass & make
        sure the unit tests are correct too.
     */

    public class EquivalenceIndex
    {
      public int Find(int[] numbers)
      {
            Dictionary<int, int> leftSum = new Dictionary<int, int>();
            int equivalenceIndex = -1;
            int sum = 0;

            if (numbers is null || numbers.Length == 0)
                throw new ArgumentException("Numbers are required");

            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
                leftSum.Add(sum, i);
            }

            sum = 0;
            for(int i = numbers.Length -1; i > -1; i--)
            {
                sum += numbers[i];

                if (leftSum.ContainsKey(sum) && leftSum[sum] == (i - 2))
                {
                    equivalenceIndex = i - 1;
                    break;
                }
            }

            return equivalenceIndex;
      }
    }
}
