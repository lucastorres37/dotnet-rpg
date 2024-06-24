using dotnet_rpg.Models;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        /// List of characters
        private static List<Character> characters = new List<Character> {
            new Character(),
            new Character { Id = 1, Name = "Sam" }
        };

        /// Get all on the list
        [HttpGet("GetAll")]
        public ActionResult<List<Character>> Get()
        {
            return Ok(characters);
        }

        /// Pegar por personagem por id 
        [HttpGet("{id}")]
        public ActionResult<List<Character>> GetSingle(int id)
        {
            return Ok(characters.FirstOrDefault(c => c.Id == id));
        }
        
    }
}