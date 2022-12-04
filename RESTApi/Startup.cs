using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using RESTApi.Models;
using System;
using RESTApi.Models;
using Microsoft.EntityFrameworkCore;

namespace RESTApi
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void Configure(IServiceCollection services)
        {
            var connection = Configuration.GetConnectionString("StoreDB");
            services.AddDbContextPool<StoreDBContext>(options => options.UseSqlServer(connection));
        }
    }
}
