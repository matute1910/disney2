using Disney.Core.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Disney.Core.Interfaces
{
    public interface IGenderRepository : IRepository<Gender>
    {
        Task<IEnumerable<Gender>> GetListGender(string name, string image);
    }
}
