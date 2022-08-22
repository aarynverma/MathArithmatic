namespace MathCalc.Models
{
    public interface IInterest
    {
        public double SI(double p, double r, double t);
        public double CI(double p, double r, double t, double n); 
    }
}
