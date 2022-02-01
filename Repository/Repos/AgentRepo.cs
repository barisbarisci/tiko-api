using System.Collections.Generic;
using System.Data;
using System.Linq;
using Dapper;
using Microsoft.Extensions.Configuration;
using Npgsql;
using TikoAPI.Models;
using TikoAPI.Repository.IRepos;

namespace TikoAPI.Repository.Repos
{
    public class AgentRepo : IAgentRepo
    {
        private IDbConnection db;
        public AgentRepo(IConfiguration config)
        {
            this.db = new NpgsqlConnection(config.GetConnectionString("ApplicationContext"));
        }
        public Agent Add(Agent entity)
        {
            var query = "INSERT INTO agents(name,city_id) VALUES (@Name,@CityId);";

            var id = db.Query<int>(query, entity).SingleOrDefault();

            entity.Id = id;
            return entity;
        }

        public void Delete(int id)
        {
            var query = "DELETE FROM agents WHERE id = @Id";
            db.Query<Agent>(query, new { @Id = id });
        }

        public Agent Find(int id)
        {
            var query = "SELECT * FROM agents WHERE id = @Id";
            return db.Query<Agent>(query, new { @Id = id }).SingleOrDefault();
        }

        public List<Agent> List()
        {
            var query = "SELECT a.id, a.name, c.id, c.name FROM agents a INNER JOIN cities c ON a.city_id = c.id";
            return db.Query<Agent, City, Agent>(query,
            (agent, city) =>
            {
                agent.City = city;
                return agent;
            },
            splitOn: "id"
            ).ToList();
        }

        public void Update(Agent entity)
        {
            var query = "UPDATE agents SET name = @name, city_id = @CityId WHERE id = @Id";
            db.Execute(query, entity);
        }
    }
}