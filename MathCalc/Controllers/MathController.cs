using Microsoft.AspNetCore.Mvc;
using MathCalc.Models;

namespace MathCalc.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MathController : ControllerBase
    {
        public IMath _math;
        public MathController(IMath math)
        {
            _math = math;

        }

        [Route("add")]
        [HttpPost]
        public int Addition(int a, int b)
        {
            return _math.add(a, b);   
        }

        [Route("sub")]
        [HttpPost]
        public int Substraction(int a, int b)
        {
            return _math.sub(a, b);
        }

        [Route("mul")]
        [HttpPost]
        public int Multiplication(int a, int b)
        {
            return _math.mul(a, b);
        }

        [Route("divi")]
        [HttpPost]
        public double Division(double a, double b)
        {
            return _math.divi(a, b);
        }
    }
    public class InterestController : ControllerBase
    {
        public IInterest _interest;
        public InterestController(IInterest interest)
        {
            _interest = interest;

        }
        [Route("SI")]
        [HttpPost]
        public double SI(double p, double r, double t)
        {
            return _interest.SI(p, r, t);
        }

        [Route("CI")]
        [HttpPost]
        public double CI(double p, double r, double t, double n)
        {
            return _interest.CI(p, r, t, n);
        }
    }
}
