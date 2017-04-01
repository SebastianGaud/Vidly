using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController ()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose ( bool disposing )
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index ()
        {
            return View( _context
                .Customers
                .Include( m => m.MembershipType )
                .ToList() );
        }

        public ActionResult Details ( int id )
        {
            return View( _context
                .Customers
                .Include( c => c.MembershipType )
                .SingleOrDefault( c => c.Id == id ) );
        }

        public ActionResult New ()
        {
            CustomerFormViewModel viewModel = new CustomerFormViewModel()
            {
                Customer = new Customer() ,
                MembershipTypes = _context.MembershipTypes
            };

            return View( "CustomerForm" , viewModel );
        }

        public ActionResult Edit ( int id )
        {
            CustomerFormViewModel viewModel = new CustomerFormViewModel()
            {
                MembershipTypes = _context.MembershipTypes ,
                Customer = _context.Customers.Single( c => c.Id == id )
            };

            return View( "CustomerForm" , viewModel );
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save ( Customer customer )
        {
            if ( !ModelState.IsValid )
            {
                CustomerFormViewModel viewModel = new CustomerFormViewModel()
                {
                    Customer = customer ,
                    MembershipTypes = _context.MembershipTypes.ToList()
                };

                return View( "CustomerForm" , viewModel );
            }

            if ( customer.Id == 0 )
            {
                _context.Customers.Add( customer );
            }
            else
            {
                Customer customerInDb = _context.Customers.Single( c => c.Id == customer.Id );
                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MembershipTypeId = customer.MembershipTypeId;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            }
            _context.SaveChanges();
            return RedirectToAction( "Index" , "Customers" );
        }
    }
}