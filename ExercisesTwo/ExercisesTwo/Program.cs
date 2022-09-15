using System.Globalization;
internal class Program {
    private static void Main(string[] args) {


        // 1° Verify if a number is pair or odd 
        int num = int.Parse(Console.ReadLine());

        if (num % 2 == 0) {
            if (num >= 0)
                Console.WriteLine("Pair and positive");
            else
                Console.WriteLine("Pair and negative");
        }
        else {
            if (num >= 0)
                Console.WriteLine("Odd and positive");
            else
                Console.WriteLine("Odd and negative");
        }


        // 2 - Read two values and verify if they're cousin
        string[] nums = Console.ReadLine().Split(" ");

        int a = int.Parse(nums[0]);
        int b = int.Parse(nums[1]);

        if (a > b) {
            if (a % b == 0) {
                int rest = a / b;

                if (rest * b == a) {
                    Console.WriteLine("They're multiples");
                }
                else {
                    Console.WriteLine("They are similar but they aren't multiples");
                }
            }
            else {
                Console.WriteLine("They aren't multiplies");
            }
        }
        else {
            if (b % a == 0) {
                int rest = b / a;

                if (rest * a == b) {
                    Console.WriteLine("They're multiples");
                }
                else {
                    Console.WriteLine("They are similar but they aren't multiples");
                }
            }
            else {
                Console.WriteLine("They aren't multiplies");
            }
        }


        while (true) {

            Console.WriteLine("Type a number");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Number: " + number);

            if (number == 0)
                break;

            if (number < 0 || number > 100) {
                Console.WriteLine("Out of interval");
            }
            else if (number <= 25.00) {
                Console.WriteLine("Interval [0, 25]");
            }
            else if (number <= 50.0) {
                Console.WriteLine("Interval (25, 50]");
            }
            else if (number <= 75.0) {
                Console.WriteLine("Interval (50, 75]");
            }
            else {
                Console.WriteLine("Interval (75, 100]");
            }


            double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (salary <= 2000.00) {
                Console.WriteLine("Tax exempt");

            }
            else if (salary <= 3000.00) {
                double total = (salary - 2000) * 0.08;
                Console.WriteLine("R$: " + total.ToString("F2", CultureInfo.InvariantCulture));

            }
            else if (salary <= 4500.00) {
                double total = (1000 * 0.08) + (salary - 3000) * 0.18;
                Console.WriteLine("R$: " + total.ToString("F2", CultureInfo.InvariantCulture));

            }
            else {
                double total = (1000 * 0.08) + (1500 * 0.18) + (salary - 4500) * 0.28;
                Console.WriteLine("R$: " + total.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
