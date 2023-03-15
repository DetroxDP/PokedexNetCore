using Microsoft.AspNetCore.Mvc;
using Pokedex1.Datos;
using Pokedex1.Modelos;

namespace Pokedex1.Controladores
{
    [ApiController]
    [Route("api/pokedex")]
    public class pokemonController
    {
        [HttpGet]
        public async Task <ActionResult<List<pokemon>>> Get()
        {
            var funcion = new Dpokemon();
            var lista = await funcion.MostrarPokemon();
            return lista;
        }
    }
}
