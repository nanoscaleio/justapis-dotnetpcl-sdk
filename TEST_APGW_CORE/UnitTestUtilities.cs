﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using APGW;
using RichardSzalay.MockHttp;
using System.Net.Http;
using System.Threading.Tasks;
using System.Diagnostics;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using Autofac;

namespace TEST_APGW_CORE
{
    public class UnitTestUtilities: BaseUnitTest
    {
        public UnitTestUtilities ()
        {
        }

        [SetUp]
        public void Setup() {
            SetupDI ();
        }

        [Test]
        public void Test_UpdateUrl() {
            string baseUrl = "http://localhost/api/v1";
            string newUrl = "/foo";
            string resolvedUrl = Utilities.UpdateUrl (baseUrl, newUrl);

            Assert.AreEqual ("http://localhost/api/v1/foo", resolvedUrl);
                       
            baseUrl = "http://localhost/api/v1";
            newUrl = "foo";
            resolvedUrl = Utilities.UpdateUrl (baseUrl, newUrl);

            Assert.AreEqual ("http://localhost/api/v1/foo", resolvedUrl);


            baseUrl = "http://localhost/api/v1";
            newUrl = "http://localhost/api/v1/foobar";
            resolvedUrl = Utilities.UpdateUrl (baseUrl, newUrl);

            Assert.AreEqual ("http://localhost/api/v1/foobar", resolvedUrl);

            baseUrl = "http://foo.lvh.me:5000";
            newUrl = "/bar";
            resolvedUrl = Utilities.UpdateUrl (baseUrl, newUrl);

            Assert.AreEqual ("http://foo.lvh.me:5000/bar", resolvedUrl);
  
        }
    }
}

