using Microsoft.EntityFrameworkCore;
using Pokedex1.Modelos;

namespace Pokedex1.Contexto
{
    public class AplicacionBDContexto: DbContext
    {
        public DbSet<pokemon> Pokemon { get; set; }


    }
}
