using Disney.Core.Entities;
using Disney.Core.Interfaces;
using Disney.Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Disney.Infraestructure.Repositories
{
    public class CharacterRepository : BaseRepository<Character>, ICharacterRepository
    {
        public CharacterRepository(DisneyContext context) : base(context) { }

        public async Task<IEnumerable<Character>> GetListCaracter(string name, string image)
        {
            return await _entities.Where(x => x.Name == name && x.Image == image).ToListAsync();       
        }

        public async Task<IEnumerable<Character>> GetByName(string name)
        {
            return await _entities.Where(x => x.Name == name).ToListAsync();
        }

        public async Task<IEnumerable<Character>> GetByAge(int age)
        {
            return await _entities.Where(x => x.Age == age).ToListAsync();
        }

        public async Task<IEnumerable<Character>> GetByIdMovie(int idMovie)
        {
            return await _entities.Where(x => x.MoviesOrAssociatedSeries.Any(z => z.Id == idMovie)).ToListAsync();
        }
    }

}
