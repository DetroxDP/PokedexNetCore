namespace Pokedex1.Conexion
{
    public class conexionDB
    {
        private string connectionString = string.Empty;
        public conexionDB()
        {
            var constructor = new ConfigurationBuilder().SetBasePath
                (Directory.GetCurrentDirectory()).AddJsonFile
                ("appsettings.json").Build();
            connectionString = constructor.GetSection("ConnectionStrings:conexionMaestra").Value;
        }
        public string cadenaSQL()
        {
            return connectionString;
        }
    }
}
