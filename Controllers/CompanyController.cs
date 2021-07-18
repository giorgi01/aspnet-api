using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Services;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CompanyController : Controller
    {

        private CompanyService _service;

        public CompanyController()
        {
            _service = new CompanyService();
        }

        [HttpGet]
        public List<Company> Index()
        {
            return _service.GetCompanies();
        }

        [HttpGet("{name}")]
        public Company Show(string name)
        {
            return _service.GetCompany(name);
        }

        [HttpPost]
        public List<Company> Create([FromQuery] string name, [FromQuery] string hqAddress)
        {
            _service.CreateCompany(name, hqAddress);
            return _service.GetCompanies();
        }

        [HttpPut]
        public Company Update([FromQuery] string name, [FromQuery] string newAddress)
        {
            _service.UpdateCompany(name, newAddress);
            return _service.GetCompany(name);
            
        }

        [HttpDelete("{name}")]
        public List<Company> Delete(string name)
        {
            _service.DeleteCompany(name);
            return _service.GetCompanies();
        }
    }
}
