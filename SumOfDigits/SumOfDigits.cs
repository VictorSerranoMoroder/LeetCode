using System;
class SumOfDigits
{
    public static void Main() {
        int input = 0;
        Console.WriteLine(SubtractProductAndSum(input));
    }

    public static int SubtractProductAndSum(int n) {
        int sum = 0;
        int prod = 1;

        if (n == 0)
            return 0;

        while (n > 0) {
            //Console.WriteLine(n + " prod: "+prod+" sum: "+sum);
            int aux = n % 10;
            sum += aux;
            prod *= aux;
            n /= 10;
        }

        return (prod-sum);
    }
}