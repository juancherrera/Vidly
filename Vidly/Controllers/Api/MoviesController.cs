using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using AutoMapper;
using Vidly.Dtos;
using Vidly.Models;

namespace Vidly.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/movies   - will return ALL Movies
        public IEnumerable<MovieDto> GetMovies()
        {
            return _context.Movies.ToList().Select(Mapper.Map<Movie, MovieDto>);     //The parenthesis in (Mapper.Map<movie,movieDto>()); not needed as we are not calling a method, only referencing it
        }

        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movie == null)
                //throw new HttpResponseException(HttpStatusCode.NotFound);
                return NotFound();

            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        //Post /api/movies - add a new movie
        [HttpPost]
        public IHttpActionResult CreateMovie(MovieDto movieDto) //By convention, we return the newly created object to the movie for confirmation
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }


        //this is the PUT method
        [HttpPut]
        public void UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(movieDto, movieInDb);
            //movieInDb.Name = movieDto.Name;
            //movieInDb.Birthdate = movieDto.Birthdate;
            //movieInDb.IsSubscribedToNewsletter = movieDto.IsSubscribedToNewsletter;
            //movieInDb.MembershipTypeId = movieDto.MembershipTypeId;

            _context.SaveChanges();
        }


        //this is the Delete method
        [HttpDelete]
        public void DeleteMovie(int id, Movie movie)
        {
            var movieInDb = _context.Movies.SingleOrDefault(c => c.Id == id);

            if (movieInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Movies.Remove(movieInDb);

            _context.SaveChanges();
        }

    }
}