using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

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
    }
}