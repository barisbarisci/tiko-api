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
    public class HouseRepo : IHouseRepo
    {
        private IDbConnection db;
        public HouseRepo(IConfiguration config)
        {
            this.db = new NpgsqlConnection(config.GetConnectionString("ApplicationContext"));
        }
        public House Add(House entity)
        {
            var query = "INSERT INTO houses(city_id,agent_id,price,address,description,bedroom_count)"
            + " VALUES (@CityId,@AgentId,@Price,@Address,@Description,@BedroomCount);";

            var id = db.Query<int>(query, entity).SingleOrDefault();

            entity.Id = id;
            return entity;
        }

        public void Delete(int id)
        {
            var query = "DELETE FROM houses WHERE id = @Id";
            db.Query<House>(query, new { @Id = id });
        }

        public List<House> FilterList(int? cityId, int? agentId)
        {
            var query = "SELECT * FROM houses h INNER JOIN cities c ON h.city_id = c.id INNER JOIN agents a ON"
            + " a.id = h.agent_id";
            if (cityId != null)
            {
                query += " WHERE h.city_id = " + cityId;
                if (agentId != null)
                {
                    query += " AND h.agent_id = " + agentId;
                }
            }
            else if (agentId != null)
            {
                query += " WHERE h.agent_id = " + agentId;
            }
            return db.Query<House, City, Agent, House>(query, (house, city, agent) =>
               {
                   house.City = city;
                   house.Agent = agent;
                   return house;
               },
            splitOn: "id").ToList();
        }

        public House Find(int id)
        {
            var query = "SELECT * FROM houses WHERE Id = @Id";
            return db.Query<House>(query, new { @Id = id }).SingleOrDefault();
        }

        public List<House> List()
        {
            var query = "SELECT * FROM houses h INNER JOIN cities c ON h.city_id = c.id INNER JOIN agents a ON"
            + " a.id = h.agent_id";
            return db.Query<House, City, Agent, House>(query, (house, city, agent) =>
               {
                   house.City = city;
                   house.Agent = agent;
                   return house;
               },
            splitOn: "id").ToList();
        }

        public void Update(House entity)
        {
            var query = "UPDATE houses SET price = @Price"
            + " WHERE id = @Id";
            db.Execute(query, entity);
        }

        public void UpdatePrice(House entity)
        {
            var query = "UPDATE houses SET price = @Price"
            + " WHERE id = @Id";
            db.Execute(query, entity);
        }
    }
}