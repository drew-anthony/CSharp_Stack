using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Data;
using MySql.Data.MySqlClient;
using LostInTheWoods.Models;
using Microsoft.Extensions.Options;
 
namespace LostInTheWoods.Factory
{
    public class TrailsFactory
    {
        private MySqlOptions _options;
        public TrailsFactory(IOptions<MySqlOptions> config)
        {
            _options = config.Value;
        }
        internal IDbConnection Connection
        {
            get {
                return new MySqlConnection(_options.ConnectionString);
            }
        }

        public void Add(Trail trail)
        {
            using (IDbConnection dbConnection = Connection) {
                string query =  "INSERT INTO trails (id, name, description, length, elevation, longitude, latitude, created_at, updated_at) VALUES (@Id, @Name, @Description, @Length, @Elevation, @Longitude, @Latitude, NOW(), NOW())";
                dbConnection.Open();
                dbConnection.Execute(query, trail);
            }
        }
        public IEnumerable<Trail> FindAll()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return dbConnection.Query<Trail>("SELECT * FROM trails");
            }
        }
        public Trail FindByID(int id)
        {
            using (IDbConnection dbConnection = Connection)
            {
               dbConnection.Open(); 
               return dbConnection.Query<Trail>("SELECT * FROM trails WHERE id = @Id", new { id = id }).FirstOrDefault();
            }
        }







    }
}