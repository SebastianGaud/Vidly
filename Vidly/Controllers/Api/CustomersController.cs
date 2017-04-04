using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _context;

        public CustomersController ()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<Customer> GetCustomers () => _context.Customers.ToList();


        public IHttpActionResult GetCustomer ( int id )
        {
            Customer customer = _context.Customers.SingleOrDefault( c => c.Id == id );

            if ( customer == null )
            {
                return NotFound();
            }

            return Ok();
        }



    }
}
