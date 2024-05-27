using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.IO;
using System.Windows.Forms;
using TourAgency.Data;
using TourAgency.Models;
using TourAgency.Services;

namespace TourAgency
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            var serviceProvider = serviceCollection.BuildServiceProvider();

            ApplicationConfiguration.Initialize();
            Application.Run(serviceProvider.GetRequiredService<MainForm>());
        }

        private static void ConfigureServices(IServiceCollection services)
        {
            var configuration = LoadConfiguration();

            services.AddDbContext<TourAgencyContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));

            services.AddTransient<MainForm>();
            services.AddTransient<AuthForm>();
            services.AddTransient<ManageToursForm>();
            services.AddTransient<ManageBookingForm>();
            services.AddTransient<SearchToursForm>();
            services.AddTransient<ViewBookingsForm>();
            services.AddSingleton<UserSession>();
            services.AddScoped<ITourService, TourService>();
            services.AddScoped<IBookingService, BookingService>();
            services.AddScoped<IUserService, UserService>();
        }
        private static IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile("D:\\���\\2 ����\\������� 2\\��� (��������)\\TourAgency\\TourAgency\\appsettings.json", optional: false, reloadOnChange: true);

            return builder.Build();
        }
    }
}
