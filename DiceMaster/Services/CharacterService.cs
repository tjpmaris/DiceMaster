using System.Collections.Generic;
using System.Threading.Tasks;
using DiceMaster.Database;
using DiceMaster.Models;

namespace DiceMaster.Services
{
    public class CharacterService : ICharacterService
    {
        private IDAL dal;

        public CharacterService(IDAL dal) 
        {
            this.dal = dal;
        }

        public async Task<IEnumerable<Character>> GetAll() 
        {
            return await dal.GetAll<Character>();
        }

        public async Task<Character> Create(Character obj)
        {
            return await dal.Create(obj);
        }

        public async Task<Character> Delete(string id)
        {
            return await dal.Delete<Character>(id);
        }

        public async Task<Character> Get(string id)
        {
            return await dal.Get<Character>(id);
        }

        public async Task<Character> Update(Character obj)
        {
            return await dal.Update(obj);
        }
    }
}