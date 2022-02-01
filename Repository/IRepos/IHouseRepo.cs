using System.Collections.Generic;
using TikoAPI.Models;

namespace TikoAPI.Repository.IRepos
{
    public interface IHouseRepo : ICoreRepo<House>
    {
        List<House> FilterList(int? cityId, int? agentId);
        void UpdatePrice(House entity);
    }
}