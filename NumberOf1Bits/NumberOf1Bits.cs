using System;

class NumberOf1Bits
{
    public static void Main() {
        uint num = 1010;
        Console.WriteLine(HammingWeight(num));
    }

    public static int HammingWeight(uint n) {
        int bits1 = 0;
        while (n > 0) {
            if (n % 2 != 0) //1
                bits1++;
            n = (n >> 1);
        }
        return bits1;
    }
    
}