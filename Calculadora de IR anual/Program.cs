using IncomeTax_Presentation;
using IncomeTax_Presentation.Interfaces;
using IncomeTax_Services; 
using IncomeTax_Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace IncomeTax_Calculator 
{ 
    public class Program
    {
        public static void Main()
        {
            ServiceCollection services = new();
            ConfigureServices(services);

            var serviceProvider = services.BuildServiceProvider();

            var layout = serviceProvider.GetService<ILayout>();

            layout.Taxpayer();

            var taxCalculation = serviceProvider.GetService<ITaxCalculator>();

        }

        public static void ConfigureServices(IServiceCollection services)
        {
            services
                .AddScoped<ILayout, Layout>()
                .AddScoped<ITaxCalculator, TaxCalculation>();
        }
    }
}
