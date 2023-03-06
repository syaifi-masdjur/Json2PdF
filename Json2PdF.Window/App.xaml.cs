using Json2PdF.Window.ViewModels;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Json2PdF.Window
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {


        public static IHost? Host { get; private set; }

        public App()
        {
            Host = Microsoft.Extensions.Hosting.Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    ConfigureServices(services);
                })
                .Build();
        }

        private void ConfigureServices(IServiceCollection services)
        {
            // Add Services
            services.AddSingleton<MainViewModel, MainViewModel>();
            services.AddSingleton<MainWindow>();
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await Host!.StartAsync();

            var mainViewModel = Host.Services.GetRequiredService<MainViewModel>();
            var mainWindow = Host.Services.GetRequiredService<MainWindow>();
            mainWindow.DataContext = mainViewModel;
            mainWindow.Show();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await Host!.StopAsync();
            base.OnExit(e);
        }
      
    }
}
