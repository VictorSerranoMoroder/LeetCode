using System;   

class PowerOfFour
{
    public static void Main() {
        
        int number = 1162261466;
        Console.WriteLine(IsPowerOfFour(number));
    }

    public static bool IsPowerOfFour(int n) {
        long acc = 1;

        while (acc < n)
            acc = (acc << 2);

        if (acc == n)
            return true;
        else 
            return false;
    }
}