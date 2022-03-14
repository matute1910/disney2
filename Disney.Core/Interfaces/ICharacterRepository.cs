using Disney.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Disney.Core.Interfaces
{
    public interface ICharacterRepository : IRepository<Character>
    {
        Task<IEnumerable<Character>> GetListCaracter(string name, string image);
        Task<IEnumerable<Character>> GetByAge(int age);
        Task<IEnumerable<Character>> GetByIdMovie(int idMovie);
    }
}
