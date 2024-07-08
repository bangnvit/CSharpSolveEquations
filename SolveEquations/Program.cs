namespace SolveEquations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solve linear equation ax + b = 0");
            double a = GetValidDouble("Enter coeficient a: ");
            double b = GetValidDouble("Enter coeficient b: ");

            SolveLinearEquation(a, b);


            Console.WriteLine("\nSolve quadratic equation ax^2 + bx + c = 0 (a != 0)");
            double a1;
            do
            {
                a1 = GetValidDouble("Enter coeficient a: ");
                if (a1 == 0)
                {
                    Console.WriteLine("Quadratic equation has a != 0. Please enter again.");
                }
            } while (a1 == 0);
            double b1 = GetValidDouble("Enter coeficient b: ");
            double c1 = GetValidDouble("Enter coeficient c: ");

            SolveQuadraticEquation(a1, b1, c1);
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

        private static void SolveQuadraticEquation(double a, double b, double c)
        {
            double delta = b*b - 4*a*c;
            if (delta < 0)
            {
                Console.WriteLine("The equation has no solution.");
            }
            else if (delta == 0) 
            {
                Console.WriteLine($"The equation {a}x^2 + {b}x + {c} = 0 has double solution x1 = x2 = {-b/(2*a)}");
            }
            else
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                Console.WriteLine($"The equation {a}x^2 + {b}x + {c} = 0 has two distinct solutions x1 = {x1},  x2 = {x2}");
            }
        }
    }
}
