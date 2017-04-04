using System;
using System.Linq;
using System.Web.Http;
using AutoMapper;
using Vidly.DTOS;
using Vidly.Interfaces;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController, IMoviesController
    {
        private readonly ApplicationDbContext _context;

        public MoviesController ()
        {
            _context = new ApplicationDbContext();
        }

        public IHttpActionResult GetMovies () =>
            Ok( _context.Movies.ToList().Select( Mapper.Map<Movie , MovieDTO> ) );

        public IHttpActionResult GetMovie ( int id )
        {
            var movie = _context.Movies.SingleOrDefault( c => c.Id == id );

            if ( movie == null )
            {
                return NotFound();
            }

            return Ok( Mapper.Map<Movie , MovieDTO>( movie ) );
        }

        [HttpPut]
        public IHttpActionResult UpdateMovie ( int id , MovieDTO movieDto )
        {
            if ( !ModelState.IsValid )
            {
                return BadRequest();
            }

            var movieInDb = _context.Movies.SingleOrDefault( m => m.Id == id );

            if ( movieInDb == null )
            {
                return NotFound();
            }

            Mapper.Map( movieDto , movieInDb );

            _context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public IHttpActionResult Deletemovie ( int id )
        {
            if ( !ModelState.IsValid )
            {
                return BadRequest();
            }

            var movieInDb = _context.Movies.SingleOrDefault( m => m.Id == id );

            if ( movieInDb == null )
            {
                return NotFound();
            }

            _context.Movies.Remove( movieInDb );
            _context.SaveChanges();

            return Ok();
        }

        [HttpPost]
        public IHttpActionResult CreateMovie ( MovieDTO movieDto )
        {
            if ( !ModelState.IsValid )
            {
                return BadRequest();
            }

            var movie = Mapper.Map<MovieDTO , Movie>( movieDto );

            _context.Movies.Add( movie );
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created( new Uri( Request.RequestUri + "/" + movie.Id ) , movieDto );
        }
    }
}
