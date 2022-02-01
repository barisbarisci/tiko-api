using Microsoft.Extensions.DependencyInjection;
using TikoAPI.Repository.IRepos;
using TikoAPI.Repository.Repos;

namespace TikoAPI.Repository
{
    public class RepositoryConfig
    {
        public static void ConfigureService(IServiceCollection services)
        {
            services.AddScoped<ICityRepo, CityRepo>();
            services.AddScoped<IAgentRepo, AgentRepo>();
            services.AddScoped<IHouseRepo, HouseRepo>();
        }
    }
}