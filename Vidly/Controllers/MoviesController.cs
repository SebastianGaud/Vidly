using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController ()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose ( bool disposing )
        {
            _context.Dispose();
        }

        // GET: Movies
        public ActionResult Index ()
        {
            return View( _context
                .Movies
                .Include( g => g.Genre )
                .ToList() );
        }

        public ActionResult Details ( int id )
        {
            return View( _context
                .Movies
                .Include( g => g.Genre )
                .SingleOrDefault( m => m.Id == id ) );
        }
    }
}