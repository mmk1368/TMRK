using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TMRK.Business;
using TMRK.UnitOfWork;
using AutoMapper;
using TMRK.Models;

namespace TMRK.Config.PipeLines
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencies(this IServiceCollection services)
        {
            services.AddScoped<IDataBase, DataBase>();
            services.AddScoped<ILogDataBase, LogDataBase>();
            services.AddScoped<ICAI, CAI>();
            //services.AddScoped<IMapper, >();
            //services.AddScoped<IComment, Comment>();
            //services.AddScoped<IFirstPage, FirstPage>();
            //services.AddScoped<IInstaUser, InstaUser>();
            //services.AddScoped<IPost, Post>();
            //services.AddScoped<IProduct, Product>();
            //services.AddScoped<IInstagram, Instagram>();
            return services;
        }
    }
}
