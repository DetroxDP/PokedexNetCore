using Microsoft.Data.SqlClient;
using Pokedex1.Conexion;
using Pokedex1.Modelos;
namespace Pokedex1.Datos
{
    public class Dpokemon
    {
        conexionDB cn = new conexionDB();
        public async Task<List<pokemon>> MostrarPokemon()
        {
            var lista = new List<pokemon>();
            using (var sql = new SqlConnection(cn.cadenaSQL()))
            {
                using (var cmd = new SqlCommand("sp_mostrarPokemon", sql))
                {
                    await sql.OpenAsync();
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    using(var item = await cmd.ExecuteReaderAsync())
                    {
                        while (await item.ReadAsync())
                        {
                            var pokemon = new pokemon();

                            pokemon.id = (int)item["id"];
                            pokemon.Nombre = (string)item["nombre"];
                            pokemon.imagen = (string)item["imagen"];
                            lista.Add(pokemon);
                        }
                    }
                }
            }
            return lista;
        }
    }
}
