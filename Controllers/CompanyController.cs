using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return Json("Index");
        }

        [HttpGet("{id}")]
        public IActionResult Show(int id)
        {
            return Json("Show");
        }

        [HttpPost]
        public IActionResult Create()
        {
            return Json("Create");
        }

        [HttpPut]
        public IActionResult Update(int id)
        {
            return View();
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            return View();
        }
    }
}
