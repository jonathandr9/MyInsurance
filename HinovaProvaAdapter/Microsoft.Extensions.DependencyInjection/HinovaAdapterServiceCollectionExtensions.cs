using HinovaProvaAdapter;
using HinovaProvaAdapter.Clients;
using Microsoft.Extensions.DependencyInjection;
using MyInsurance.Domain.Adapters;
using System;
using Refit;

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

            //services.AddScoped(serviceProvider =>
            //{
            //    var httpClientFactory = serviceProvider
            //    .GetService<IHttpClientFactory>();

            //    var httpClient = httpClientFactory
            //       .CreateClient();

            //    httpClient.BaseAddress =
            //        new Uri(hinovaAdapterConfiguration
            //            .ApiUrlBase);

            //    return RestService
            //        .For<IHinovaWebApi>(httpClient);
            //});

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
