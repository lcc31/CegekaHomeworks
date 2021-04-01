using Homework4.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Homework4.Controllers
{
    public class CustomerController : Controller
    {
        public List<EntityCustomer> _customers = DatabaseCustomers.Customers;

        [HttpGet]
        [Route("api/customers")]
        public ActionResult GetAllCustomers()
        {
            return Ok(_customers);
        }

        [HttpGet]
        [Route("api/customers/{LastName}")]
        public ActionResult GetCustomerByLastName(string lastname)
        {
            return Ok(_customers.FindAll(x => x.LastName.ToLower() == lastname.ToLower()));
        }

        [HttpPost]
        [Route("api/customers")]
        public ActionResult CreateNewCustomer([FromBody] EntityCustomer customerEntity)
        {
            if (_customers.Any(x => x.Id == customerEntity.Id))
            {
                return BadRequest();
            }
            _customers.Add(customerEntity);
            return Ok(customerEntity);
        }

        [HttpPut]
        [Route("api/customers/{id}")]
        public ActionResult UpdateCustomer(int id, [FromBody] EntityCustomer customerEntity)
        {
            if (customerEntity == null)
            {
                return BadRequest();
            }

            var customer = _customers.FirstOrDefault(x => x.Id == customerEntity.Id);
            if (customer == null)
            {
                return NotFound();
            }

            customer.FirstName = customerEntity.FirstName;
            customer.LastName = customerEntity.LastName;
            customer.BoughtVehicles = customerEntity.BoughtVehicles;

            return Ok(customer);
        }

        [HttpDelete]
        [Route("api/customers/{id}")]
        public ActionResult RemoveCustomer(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var customer = _customers.FirstOrDefault(x => x.Id == id);
            if (customer == null)
            {
                return BadRequest();
            }
            _customers.Remove(customer);
            return Ok();
        }

    }
}
