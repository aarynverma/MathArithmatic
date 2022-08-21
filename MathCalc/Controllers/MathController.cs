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

        [Route("SI")]
        [HttpPost]
        public double SI(double p, double r, double t)
        {
            return (p * r * t) / 100;
        }

        [Route("CI")]
        [HttpPost]
        public double CI(double p, double r, double t, double n)
        {
            return p * (1 + ((r / 4) / 100)) - p;
        }


    }
}
