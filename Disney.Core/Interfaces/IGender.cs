using Disney.Core.Entities;
using System.Collections.Generic;

namespace Disney.Core.Interfaces
{
    public interface IGender
    {
        string Image { get; set; }       
        string Name { get; set; }
        IEnumerable<MovieOrSeries> MoviesOrAssociatedSeries { get; set; }
    }
}