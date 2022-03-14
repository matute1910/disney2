using Disney.Core.Entities;
using Disney.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Disney.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class GenderController : Controller
    {

        private readonly IGenderRepository _genderRepository;


        public GenderController(IGenderRepository genderRepository)
        {
            _genderRepository = genderRepository;

        }

        [HttpGet]
        public IEnumerable<Gender> GetAllCharacter()
        {
            var gender = _genderRepository.GetAll();
            return gender;
        }

      
        [HttpPost]
        public async Task<Gender> Posts(Gender gender)
        {
            await _genderRepository.Add(gender);

            return gender;
        }

        /*[HttpPut("{id}")]
        public async Task<Character> Update(int id, Character character)
        {
            var update = await _characterRepository.Update(character);
            return update;

        }*/

        [HttpDelete("{id}")]
        public Task Delete(int id)
        {
            var delete = _genderRepository.Delete(id);

            return delete;
        }
    }
}

