﻿namespace Divisibility
{
  public class DivisibilityCalculator
  {
    /// <summary>
    /// Returns true if a is evenly divisible by both b and c, otherwise return false.
    /// If either of the divisors are zero, returns false.
    /// </summary>
    public bool CheckDivisibility(int a, int b, int c) =>
     (b != 0 && c != 0) && a % b == 0 && a % c == 0;
  }
}
