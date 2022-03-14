using Disney.Core.Entities;
using Disney.Core.Interfaces;
using Disney.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Disney.Infraestructure.Repositories
{
    public class MovieOrSeriesRepository : BaseRepository<MovieOrSeries>, IMovieOrSeriesRepository
    {
        public MovieOrSeriesRepository(DisneyContext context) : base(context) { }

        public Task<IEnumerable<Gender>> GetGender(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<MovieOrSeries>> GetListMovieOrSeries(string tittle, string image, DateTime creationDate)
        {
            return await _entities.Where(x => x.Tittle == tittle && x.Image == image && x.CreationDate == creationDate).ToListAsync();
        }

        public Task<IEnumerable<MovieOrSeries>> GetNameMovieOrSeries(string name)
        {
            throw new NotImplementedException();
        }
    }
}
