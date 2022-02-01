using System.Collections.Generic;
using System.Data;
using Microsoft.Extensions.Configuration;
using TikoAPI.Models;
using TikoAPI.Repository.IRepos;
using Dapper;
using System.Linq;
using Npgsql;

namespace TikoAPI.Repository.Repos
{
    public class CityRepo : ICityRepo
    {
        private IDbConnection db;

        public CityRepo(IConfiguration config)
        {
            this.db = new NpgsqlConnection(config.GetConnectionString("ApplicationContext"));
        }

        public City Add(City entity)
        {
            var query = "INSERT INTO cities(name) VALUES (@Name);";

            var id = db.Query<int>(query, entity).SingleOrDefault();

            entity.Id = id;
            return entity;

        }

        public void Delete(int id)
        {
            var query = "DELETE FROM cities WHERE id = @Id";
            db.Query<City>(query, new { @Id = id });
        }

        public City Find(int id)
        {
            var query = "SELECT * FROM cities WHERE Id = @Id";
            return db.Query<City>(query, new { @Id = id }).SingleOrDefault();
        }

        public List<City> List()
        {
            var query = "SELECT * FROM cities";
            return db.Query<City>(query).ToList();
        }

        public void Update(City entity)
        {
            var query = "UPDATE cities SET name = @name WHERE id = @Id";
            db.Execute(query, entity);
        }
    }
}