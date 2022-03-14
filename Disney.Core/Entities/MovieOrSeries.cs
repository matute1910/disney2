using Disney.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disney.Core.Entities
{
    public class MovieOrSeries : BaseEntity, IMovieSeries
    {
        public string Tittle { get; set; }
        public DateTime CreationDate { get; set; }       
        public int Qualification { get; set; }
        public string Image { get; set; }
        public IEnumerable<Character> ListOfCharacters { get; set; }
    }
}
