using Disney.Core.Entities;
using System;
using System.Collections.Generic;

namespace Disney.Core.Interfaces
{
    public interface IMovieSeries
    {
        string Tittle { get; set; }
        DateTime CreationDate { get; set; }
        int Qualification { get; set; }
        string Image { get; set; }
        IEnumerable<Character> ListOfCharacters { get; set; }
    }
}
