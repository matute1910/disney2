using Disney.Core.Entities;
using System.Collections.Generic;

namespace Disney.Core.DTOS
{
    public class GenderDto
    {
        public string Image { get; set; }
        public string Name { get; set; }
        public IEnumerable<MovieOrSeries> MoviesOrAssociatedSeries { get; set; }
    }
}
