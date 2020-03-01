using System;
using HotChocolate;
using Microsoft.Extensions.DependencyInjection;

namespace NeoHC
{
    public partial class Startup
    {
        private void ConfigureHotChocolate(IServiceCollection services)
        {
            services
                .AddGraphQL(
                    SchemaBuilder.New()
                        .AddQueryType(d => d.Name("Query"))
                        .AddType<PersonQueries>());
        }
    }
}
