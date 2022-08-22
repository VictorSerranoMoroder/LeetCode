class AverageSalary
{
    public static void Main() {
        int [] salary = {1000,2000,3000};
        System.Console.WriteLine(
            Average(salary)
        );
    }

    public static double Average(int[] salary) {

        double acc = 0;
        int min = 0, max = 0;
        for (int i = 0; i < salary.Length;i++){
            if (salary[i] < salary[min])
                min = i;
            else if (salary[i] > salary[max])
                max = i;
        }

        for (int i = 0; i < salary.Length; i++) {
            if (i != min && i != max)
                acc += salary[i];
        }

        return acc/(salary.Length-2);
    }
}