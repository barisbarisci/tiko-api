using System.ComponentModel.DataAnnotations.Schema;
using TikoAPI.Models.Core;

namespace TikoAPI.Models
{
    public class Agent : CoreModel
    {
        [Column("name")]
        public string Name { get; set; }
        [Column("city_id")]
        public int CityId { get; set; }
        public City City { get; set; }
    }
}