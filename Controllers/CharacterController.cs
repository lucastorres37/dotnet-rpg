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
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        /// Get all on the list
        [HttpGet("GetAll")]
        public async Task<ActionResult<List<Character>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        /// Pegar por personagem por id 
        [HttpGet("{id}")]
        public async Task<ActionResult<List<Character>>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterId(id));
        }
        
        [HttpPost]
        public async Task<ActionResult<List<Character>>> AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return Ok(await _characterService.AddCharacter(newCharacter));
        }
    }
}