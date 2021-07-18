using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Services
{
    public class CompanyService
    {
        private List<Company> _companies = new List<Company>() {
            new Company("Microsoft", "SF"),
            new Company("Google", "Mountain View"),
            new Company("Apple", "IDK"),
            new Company("TBC", "Tbilisi")
        };

        public List<Company> GetCompanies()
        {
            return _companies;
        }

        public Company GetCompany(string name)
        {
            return _companies.Find(c => c.Name.Equals(name));
        }

        internal bool CreateCompany(string name, string hqAddress)
        {
            _companies.Add(new Company(name, hqAddress));
            return true;
        }

        internal bool UpdateCompany(string name, string newAddress)
        {
            _companies.Find(c => c.Name.Equals(name)).HQAddress = newAddress;
            return true;
        }

        internal bool DeleteCompany(string name)
        {
            _companies.Remove(_companies.Find(c => c.Name.Equals(name)));
            return true;
        }
    }
}
