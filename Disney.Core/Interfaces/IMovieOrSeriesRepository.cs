using Disney.Core.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Disney.Core.Interfaces
{
    public interface IMovieOrSeriesRepository :IRepository<MovieOrSeries>
    {
        Task<IEnumerable<MovieOrSeries>> GetListMovieOrSeries(string tittle, string image, DateTime CreationDate);

        Task<IEnumerable<MovieOrSeries>> GetNameMovieOrSeries(string name);
        Task<IEnumerable<Gender>> GetGender(int id);
    }
}
