
using System;
class CountOddNumbersInAnIntervalRange
{
    public static void Main() {
        int low = 3;
        int high = 7;
        Console.WriteLine(
            CountOdds(low, high)
        );
    }

    public static int CountOdds(int low, int high) {
        int odds = 0;

        if (low % 2 == 0)
            low += 1;
        while (low <= high) {
            if (low % 2 != 0) {
                odds++;
                //Console.WriteLine(low);
            }
            low++;
        }
        return odds;
    }
}