using Disney.Core.Entities;
using System.Collections.Generic;

namespace Disney.Core.Interfaces
{
    public interface ICharacter
    {
        string Name { get; set; }
        int Age { get; set; }
        int Weight { get; set; }
        string History { get; set; }           
        string Image { get; set; }
   
        IEnumerable<MovieOrSeries> MoviesOrAssociatedSeries { get; set; }
    }
}