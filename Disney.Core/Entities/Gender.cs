using Disney.Core.Interfaces;
using System.Collections.Generic;

namespace Disney.Core.Entities
{
    public class Gender : BaseEntity, IGender
    {
        public string Name { get; set; }
        public string Image { get; set; }

        public IEnumerable<MovieOrSeries> MoviesOrAssociatedSeries { get; set; }

    }
}
