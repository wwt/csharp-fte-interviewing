using Microsoft.Extensions.DependencyInjection;
using Data.Datastore;

namespace Data;

public static class Configuration
{
    public static IServiceCollection LoadDatabase(this IServiceCollection serviceCollection) =>
        serviceCollection.AddSingleton<IRepository>(
            _ => new Repository(SampleData.Albums, SampleData.Artists, SampleData.Songs)
        );
}
