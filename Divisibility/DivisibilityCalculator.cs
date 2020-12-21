namespace Divisibility
{
  public class DivisibilityCalculator
  {
    /// <summary>
    /// Returns true if a is evenly divisible by both b and c, otherwise return false.
    /// If either of the divisors are zero, returns false.
    /// </summary>
    public bool CheckDivisibility(int a, int b, int c)
    {
      if (b == 0 || c == 0)
      {
        return false;
      }
      if (a % b == 0 && a % c == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
