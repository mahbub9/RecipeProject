using Autofac;
using FirstDemo.Domain.Contexts;
using FirstDemo.Domain.Repositories;
using FirstDemo.Domain.Services;
using FirstDemo.Domain.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Domain
{
    public class DomainModule : Module
    {
        private readonly string _connectionString;
        private readonly string _migrationAssemblyName;

        public DomainModule(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<RecipeContext>().AsSelf()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();

            builder.RegisterType<RecipeContext>().As<IRecipeContext>()
                .WithParameter("connectionString", _connectionString)
                .WithParameter("migrationAssemblyName", _migrationAssemblyName)
                .InstancePerLifetimeScope();           

            builder.RegisterType<ReceipeRepository>().As<IReceipeRepository>()
                .InstancePerLifetimeScope();
            builder.RegisterType<IngrediantRepository>().As<IIngrediantRepository>()
                .InstancePerLifetimeScope();

            builder.RegisterType<RecipeUnitOfWork>().As<IRecipeUnitOfWork>()
                .InstancePerLifetimeScope();            

            builder.RegisterType<RecipeService>().As<IReceipeService>()
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
