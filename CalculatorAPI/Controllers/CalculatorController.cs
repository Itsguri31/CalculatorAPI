using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        [HttpGet("add")]
        public decimal Add(decimal left, decimal right)
        {
            return left + right;
        }

        [HttpGet("subtract")]
        public decimal Subtract(decimal left, decimal right)
        {
            return left - right; 
        }

        [HttpGet("multiply")]
        public decimal Multiply(decimal left, decimal right)
        {
            return left * right;
        }

        [HttpGet("divide")]
        public decimal Divide(decimal left, decimal right)
        {
            
            return left / right; 
        }

        [HttpGet("modulo")]
        public decimal Modulo(decimal left, decimal right)
        {
            return left % right; 
        }
    }
}
