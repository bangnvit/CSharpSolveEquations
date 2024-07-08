namespace SolveEquations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = GetValidDouble("Enter coeficient a: ");
            double b = GetValidDouble("Enter coeficient b: ");
            
            SolveLinearEquation(a, b);
        }

        private static double GetValidDouble(string promt)
        {
            double numble;
            bool isValid;

            do
            {
                Console.Write(promt);
                string input = Console.ReadLine();

                isValid = double.TryParse(input, out numble);

                if (!isValid)
                {
                    Console.WriteLine("Invalid input. Please enter again.");
                }
            } while (!isValid);

            return numble;
        }

        private static void SolveLinearEquation(double a, double b)
        {
            if (a == 0)
            {
                if (b == 0)
                {
                    Console.WriteLine("The equation has infinite solutions.");
                }
                else
                {
                    Console.WriteLine("The equation has no solution.");
                }
            }
            else
            {
                Console.WriteLine($"The equation {a}x + {b} = 0 has solution: x = {-b/a}");
            }
        }
    }
}
