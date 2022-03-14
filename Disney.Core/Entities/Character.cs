using Disney.Core.Interfaces;
using System.Collections.Generic;

namespace Disney.Core.Entities
{
    public class Character : BaseEntity, ICharacter
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public string History { get; set; }     
        public string Image { get; set; }
        
        public IEnumerable<MovieOrSeries> MoviesOrAssociatedSeries { get; set; }
}
}
