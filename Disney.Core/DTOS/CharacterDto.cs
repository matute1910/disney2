using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disney.Core.DTOS
{
     public class CharacterDto
     {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Weight { get; set; }
        public string History { get; set; }
        public string MoviesOrAssociatedSeries { get; set; }
        public string Image { get; set; }
    }
}
