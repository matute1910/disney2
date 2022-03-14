using Disney.Core.Entities;
using Disney.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Disney.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MovieOrSeriesController : ControllerBase
    {
        private readonly IMovieOrSeriesRepository _movieOrSeriesRepository;

        public MovieOrSeriesController(IMovieOrSeriesRepository movieOrSeriesRepository)
        {
            _movieOrSeriesRepository = movieOrSeriesRepository;

        }

        [HttpGet]
        public IEnumerable<MovieOrSeries> GetAllCharacter()
        {
            var movieOrSeries = _movieOrSeriesRepository.GetAll();
            return movieOrSeries;
        }

        [HttpGet("/Movies")]
        public async Task<IEnumerable<MovieOrSeries>> GetListMovieOrSeries(string tittle, string image, DateTime creationDate)
        {
            var listMovieOrSeries = await _movieOrSeriesRepository.GetListMovieOrSeries(tittle, image, creationDate);

            return listMovieOrSeries;
        }

        [HttpPost]
        public async Task<MovieOrSeries> Posts(MovieOrSeries movieOrSeries)
        {
            await _movieOrSeriesRepository.Add(movieOrSeries);

            return movieOrSeries;
        }

        /*[HttpPut("{id}")]
        public async Task<Character> Update(int id, Character character)
        {
        var update = await _characterRepository.Update(character);
        return update;

        }*/

        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
            var delete = _movieOrSeriesRepository.Delete(id);

            return delete;
        }

    }
}
