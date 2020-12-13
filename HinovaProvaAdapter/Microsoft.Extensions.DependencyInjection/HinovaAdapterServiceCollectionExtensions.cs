using HinovaProvaAdapter;
using HinovaProvaAdapter.Clients;
using MyInsurance.Domain.Adapters;
using Refit;
using System;

namespace Microsoft.Extensions.DependencyInjection
{
    public static class HinovaAdapterServiceCollectionExtensions
    {
        public static IServiceCollection AddHinovaAdapter(
            this IServiceCollection services,
            HinovaAdapterConfiguration
            hinovaAdapterConfiguration
            )
        {
            if (services == null)
            {
                throw new ArgumentNullException(nameof(services));
            }

            if (hinovaAdapterConfiguration == null)
            {
                throw new ArgumentNullException
                    (nameof(hinovaAdapterConfiguration));
            }

            services.AddSingleton
                (hinovaAdapterConfiguration);

            services.AddRefitClient<IHinovaWebApi>()
               .ConfigureHttpClient(
                   c => c.BaseAddress = new Uri(hinovaAdapterConfiguration
                        .ApiUrlBase));

            services.AddScoped<
                IHinovaAdapter,
                HinovaAdapter>();

            return services;
        }
    }
}
