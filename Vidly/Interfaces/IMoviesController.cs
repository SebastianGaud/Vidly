#region #fileheader
// Sebastiano Gaudeano
// Vidly Vidly IMoviesController.cs
// 2017 04 04
// 2017 04 04
#endregion

using System.Web.Http;
using Vidly.DTOS;

namespace Vidly.Interfaces
{
    public interface IMoviesController
    {
        IHttpActionResult GetMovies ();

        IHttpActionResult GetMovie ( int id );

        IHttpActionResult CreateMovie ( MovieDTO movieDto );

        IHttpActionResult UpdateMovie ( int id , MovieDTO movieDto );

        IHttpActionResult Deletemovie ( int id );
    }
}