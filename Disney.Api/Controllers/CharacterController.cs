using AutoMapper;
using Disney.Core.DTOS;
using Disney.Core.Entities;
using Disney.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Disney.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterRepository _characterRepository; 
        
        
        public CharacterController(ICharacterRepository characterRepository)     
        {
            _characterRepository = characterRepository;
            
        }

        [HttpGet]
        public IEnumerable<Character> GetAllCharacter()
        {
            var character = _characterRepository.GetAll();
             return character;
        }

        [HttpGet("{name}")]
        public async Task<IEnumerable<Character>> GetListCaracter(string nombre, string image)
        {
            var character = await _characterRepository.GetListCaracter(nombre, image);
            return  character;
        }

        [HttpPost]
        public async Task<Character> Posts(Character character)
        {
            await _characterRepository.Add(character);

            return character;
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
             var delete = _characterRepository.Delete(id);
           
            return delete;
        }
    }
}

