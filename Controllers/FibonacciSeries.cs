using Microsoft.AspNetCore.Mvc;
using System.Net.Mime;
using System.Text.Json;

namespace FibonacciApi.Controllers
{
    /// <summary>
    /// Fibonacci controller...
    /// </summary>
    [Route("api/v1/fibonacci")]
    [ApiController]
    public class FibonacciSeries : Controller
    {

        private readonly IFibonacci _fibonacci;

        /// <summary>
        /// Default Constructor
        /// </summary>
        /// <param name="fibonacci"></param>
        public FibonacciSeries(IFibonacci fibonacci)
        {
            _fibonacci = fibonacci;
        }

        /// <summary>
        /// Returns an integer representing the Fibonacci series value requested by parameter.
        /// </summary>
        /// <param name="index">Fibonacci series index value to return.</param>
        /// <returns>Fibonacci value that corresponds to the given index.</returns>
        [HttpGet("{index:int}")]
        public IActionResult Get(int index)
        {
            if (index < 0)
                return BadRequest("Enter a number greater than zero");

            var result = _fibonacci.GetValueOfFibonacciSeries(index);
            return Json(new { Value = result });
          
        }
    }
}
