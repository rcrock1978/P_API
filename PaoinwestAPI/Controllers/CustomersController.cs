using AutoMapper;
using Newtonsoft.Json;
using PaoinwestAPI.Persistence;
using PaoinwestAPI.Core;
using PaoinwestAPI.Core.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PaoinwestAPI.Controllers
{
    public class CustomersController : ApiController
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomersController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        // GET api/values/5
        public IHttpActionResult Get()
        {
            var customers = _unitOfWork.Customers.GetCustomers();
            IEnumerable<CustomerDto> cust = customers.Select(Mapper.Map<Customer, CustomerDto>);
            return Json(JsonConvert.SerializeObject(cust.ToList()));
        }
    }
}
