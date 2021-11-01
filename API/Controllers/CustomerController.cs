using Microsoft.AspNetCore.Mvc;
using Share.Interfaces;
using Share.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerSvc _customerSvc;
        public CustomerController(ICustomerSvc customerSvc)
        {
            _customerSvc = customerSvc;
        }

        // GET: api/GetCustomer/5
        [HttpGet]
        public async Task<ActionResult<Customer>> GetCustomer([FromQuery] int id)
        {
            return await _customerSvc.GetCustomerAsync(id);
        }

        // POST api/Customer
        // To protect fcrom overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<int>> CreateCustomer(Customer customer)
        {
            try
            {
                int id = await _customerSvc.AddCustomerAsync(customer);
                customer.CustomerId = id;
            }
            catch
            {
                //return BadRequest();
            }
            return Ok(1);
        }

        // PUT api/Customer/5
        // To protect fcrom overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<int>> UpdateCustomer(int id, Customer customer)
        {
            try
            {
                await _customerSvc.EditCustomerAsync(id, customer);
            }
            catch
            {
                //return BadRequest();
            }
            return Ok(1);
        }
    }
}