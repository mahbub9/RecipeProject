﻿using Autofac;
using FirstDemo.Common.Utilities;

namespace FirstDemo.Common
{
    public class CommonModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<DateTimeUtility>().As<IDateTimeUtility>()
                .InstancePerLifetimeScope();

            builder.RegisterType<EmailService>().As<IEmailService>()
                .WithParameter("host", "smtp.gmail.com")
                .WithParameter("port", 465)
                .WithParameter("username", "jalal.exe@gmail.com")
                .WithParameter("password", "")
                .WithParameter("useSSL", true)
                .WithParameter("from", "jalal.exe@gmail.com")
                .InstancePerLifetimeScope();

            base.Load(builder);
        }
    }
}
