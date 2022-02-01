using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TikoAPI.Models.Core;

namespace TikoAPI.Models
{
    public class House : CoreModel
    {
        [Column("city_id")]
        public int CityId { get; set; }
        public City City { get; set; }
        [Column("agent_id")]
        public int AgentId { get; set; }
        public Agent Agent { get; set; }
        [Column("price")]
        public decimal Price { get; set; }
        [Column("address")]
        public string Address { get; set; }
        [Column("description")]
        public string Description { get; set; }
        [Range(1, 10), Required, Column("bedroom_count")]
        public int BedroomCount { get; set; }

    }
}