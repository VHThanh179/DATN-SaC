using Microsoft.AspNetCore.Authorization;
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
        private readonly IEncodeHelper _encodeSvc;
        private readonly IAccountLogic _accountLogicSvc;
        private readonly IActivity _activitySvc;
        public CustomerController(ICustomerSvc customerSvc, IEncodeHelper encodeSvc, IAccountLogic accountLogicSvc, IActivity activitySvc)
        {
            _customerSvc = customerSvc;
            _encodeSvc = encodeSvc;
            _accountLogicSvc = accountLogicSvc;
            _activitySvc = activitySvc;
        }

        // GET: api/GetCustomer/5
        [HttpGet]
        public async Task<ActionResult<Customer>> GetCustomer([FromQuery] int id)
        {
            return await _customerSvc.GetCustomerAsync(id);
        }

        // NOTE: Method encode pass cũ khách hàng nhập
        // GET: api/Customer/GetPass/pass
        // 
        [Route("GetPass")]
        [HttpGet]
        public ActionResult<string> GetPass([FromQuery] string pass)
        {
            return _encodeSvc.Encode(pass);
        }

        [Route("GetCustomerbyMail")]
        [HttpGet]
        public async Task<ActionResult<Customer>> GetCustomerbyMail([FromQuery] string email)
        {
            return await _customerSvc.GetCustomerbyEmailAsync(email);
        }

        [Route("CheckMail")]
        [HttpGet]
        public async Task<ActionResult<bool>> CheckMail([FromQuery] string email)
        {
            return await _customerSvc.CheckEmail(email);
        }

        [Route("CheckPhoneNumber")]
        [HttpGet]
        public async Task<ActionResult<bool>> CheckPhoneNumber([FromQuery] string phoneNumber)
        {
            return await _customerSvc.CheckPhoneNumber(phoneNumber);
        }

        [HttpPost]
        [Route("login-google-customer")]
        public async Task<IActionResult> LoginGoogleCustomer(LoginGoogleCustomer googleCustomer)
        {
            var result = await _accountLogicSvc.LoginGoogleCustomer(googleCustomer);
            await _activitySvc.SaveLogAsync(googleCustomer.Email);
            return Ok(result);
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
                return BadRequest();
            }
            return Ok(1);
        }

        // PUT api/Customer/5
        // To protect fcrom overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // NOTE: Xóa id ở HTTPPUT
        [HttpPut]
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