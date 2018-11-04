using System.Collections.Generic;
using System.Threading.Tasks;
using DiceMaster.Models;

namespace DiceMaster.Services
{
    public interface ICharacterService
    {
        Task<IEnumerable<Character>> GetAll();
        Task<Character> Get(string id);
        Task<Character> Update(Character obj);
        Task<Character> Create(Character obj);
        Task<Character> Delete(string id);
    }
}