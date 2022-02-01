using System.ComponentModel.DataAnnotations.Schema;
using TikoAPI.Models.Core;

namespace TikoAPI.Models
{
    public class City : CoreModel
    {
        [Column("name")]
        public string Name { get; set; }
    }
}