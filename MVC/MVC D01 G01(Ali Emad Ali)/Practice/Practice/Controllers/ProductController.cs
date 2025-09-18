using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;

namespace Practice.Controllers
{
    public class ProductController : Controller
    {
        // http://localhost:21127/Product/Laptops
        public IActionResult Laptops()
        {
            return View("Laptops");
        }

        // http://localhost:21127/Product/Medicine
        public IActionResult Medicine()
        {
            return View("Medicine");
        }
    }
}
