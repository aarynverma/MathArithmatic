namespace MathCalc.Models
{
    public class Math : IMath
    {
        public int add(int a, int b)
        {
            return a + b;
        }

        public int sub(int a, int b)
        {
            return a - b;
        }

        public int mul(int a, int b)
        {
            return a * b;
        }

        public double divi(double a, double b)
        {
            return (a / b);
        }
    }
    public class Interest: IInterest
    {
        public double SI(double p, double r, double t)
        {
            return (p * r * t) / 100;
        }

        public double CI(double p, double r, double t, double n)
        {
            return p * (1 + ((r / 4) / 100)) - p;
        }
    }
}
