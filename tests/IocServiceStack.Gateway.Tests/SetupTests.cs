﻿namespace IocServiceStack.Gateway.Tests
{
    using NUnit.Framework;
    using IocServiceStack;
    using Contracts;
    using Services;

    [SetUpFixture]
    public class SetupTests
    {
        [OneTimeSetUp]
        public void Setup()
        {
            //Configure method must be invoked, even though if there's no auto mapping required.
            var configRef = IocServicelet.Configure(config => { config.AddServices(opt => { }); });

            configRef.GetServiceFactory().Add<ICustomer, CustomerService>();

        }
    }
}
