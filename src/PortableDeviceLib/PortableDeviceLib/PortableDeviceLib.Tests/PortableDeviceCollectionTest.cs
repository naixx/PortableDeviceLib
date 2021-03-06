// <copyright file="PortableDeviceCollectionTest.cs" company="Microsoft">Copyright © Microsoft 2009</copyright>
using System;
using System.Collections.Generic;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortableDeviceLib;

namespace PortableDeviceLib
{
    /// <summary>This class contains parameterized unit tests for PortableDeviceCollection</summary>
    [PexClass(typeof(PortableDeviceCollection))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class PortableDeviceCollectionTest
    {
        /// <summary>Test stub for Count</summary>
        [PexMethod]
        public void CountGet([PexAssumeUnderTest]PortableDeviceCollection target)
        {
            // TODO: add assertions to method PortableDeviceCollectionTest.CountGet(PortableDeviceCollection)
            int result = target.Count;
            Assert.AreEqual(1, result);
        }

        /// <summary>Test stub for GetDeviceIds</summary>
        [PexMethod]
        public void GetDeviceIdsGet([PexAssumeUnderTest]PortableDeviceCollection target)
        {
            // TODO: add assertions to method PortableDeviceCollectionTest.GetDeviceIdsGet(PortableDeviceCollection)
            IEnumerable<string> result = target.GetDeviceIds;
            
        }

        /// <summary>Test stub for Instance</summary>
        [PexMethod]
        public void InstanceGet()
        {
            // TODO: add assertions to method PortableDeviceCollectionTest.InstanceGet()
            PortableDeviceCollection result = PortableDeviceCollection.Instance;
            Assert.IsNotNull(result);
        }
    }
}
