using System;
using System.Data.Entity;
using System.Linq;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;

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

        public ActionResult New ()
        {
            MovieFormViewModel viewModel = new MovieFormViewModel()
            {
                Genres = _context.Genres.ToList()
            };

            return View( "MovieForm" , viewModel );
        }

        [HttpPost]
        public ActionResult Save ( Movie movie )
        {
            movie.AddedDate = DateTime.Now;
            _context.Movies.Add( movie );
            _context.SaveChanges();

            return RedirectToAction( "Index" , "Movies" );
        }

        public ActionResult Edit ( int id )
        {
            var movie = _context.Movies.SingleOrDefault( c => c.Id == id );

            if ( movie == null )
                return HttpNotFound();

            var viewModel = new MovieFormViewModel()
            {
                Movie = movie ,
                Genres = _context.Genres.ToList()
            };

            return View( "MovieForm" , viewModel );
        }
    }
}