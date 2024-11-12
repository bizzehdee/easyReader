using easyReader.Services;
using easyReader.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace easyReader
{
    public static class ServiceCollectionExtensions
    {
        public static void AddCommonServices(this IServiceCollection collection)
        {
            collection.AddHttpClient();
            collection.AddTransient<MainWindowViewModel>();
            collection.AddTransient<FeedService>();
        }
    }
}
