using Autofac;
using Assessment.Core.Interfaces.Entry;
using Assessment.Core.Interfaces.PhoneBook;
using Assessment.Core.Services.Entry;
using Assessment.Core.Services.PhoneBook;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assessment.Core
{
    public class CoreModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PhoneBookService>().As<ICreatePhoneBook>().InstancePerLifetimeScope();
            builder.RegisterType<PhoneBookService>().As<IGetPhoneBooks>().InstancePerLifetimeScope();
            builder.RegisterType<PhoneBookService>().As<IGetPhoneBookEntryByName>().InstancePerLifetimeScope();
            builder.RegisterType<EntryService>().As<ICreateEntry>().InstancePerLifetimeScope();
        }
    }
}
