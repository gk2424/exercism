

public static class Leap
{
   public static bool IsLeapYear(int year) =>
        year.IsEvenlyDivisibleBy(400) || (year.IsEvenlyDivisibleBy(4) && !year.IsEvenlyDivisibleBy(100));
    private static bool IsEvenlyDivisibleBy(this int numerator, int denominator) => numerator % denominator == 0;
}