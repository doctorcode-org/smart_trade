using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Net.Http.Headers;
using System.Net;
using System.Net.Http.Headers;

namespace SmartTrade
{
    internal static class Program
    {
        private static readonly IServiceProvider _serviceProvider;
        private const string _ua = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/93.0.4577.63 Safari/537.36";

        static Program()
        {
            var services = new ServiceCollection();
            services.TryAddSingleton<CookieContainer>();
            services
                .AddHttpClient(Constants.SmartClient, (provider, client) =>
                {
                    client.BaseAddress = new("https://smart.mobinsb.ir");
                    ConfigureClient(provider, client);
                })
                .ConfigurePrimaryHttpMessageHandler(provider => new HttpClientHandler()
                {
                    UseCookies = true,
                    CookieContainer = provider.GetRequiredService<CookieContainer>()
                });

            services.AddHttpClient(Constants.CoreClient, (provider, client) =>
            {
                client.BaseAddress = new("https://qcore.mobinsb.ir");
                ConfigureClient(provider, client);
            });

            services.AddMemoryCache();

            services.TryAddTransient<Login>();
            services.TryAddTransient<OrderForm>();

            _serviceProvider = services.BuildServiceProvider().CreateScope().ServiceProvider;
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(_serviceProvider.GetRequiredService<Login>());
        }

        private static void ConfigureClient(IServiceProvider provider, HttpClient client)
        {
            client.DefaultRequestHeaders.Add(HeaderNames.UserAgent, _ua);

            var cache = provider.GetRequiredService<IMemoryCache>();
            var token = cache.Get<string>(Constants.AccessToken);
            if (!string.IsNullOrEmpty(token))
            {
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            }
        }
    }
}