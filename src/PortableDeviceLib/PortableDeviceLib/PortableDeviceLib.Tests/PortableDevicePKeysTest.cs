// <copyright file="PortableDevicePKeysTest.cs" company="Microsoft">Copyright © Microsoft 2009</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PortableDeviceLib;

namespace PortableDeviceLib
{
    /// <summary>This class contains parameterized unit tests for PortableDevicePKeys</summary>
    [PexClass(typeof(PortableDevicePKeys))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class PortableDevicePKeysTest
    {
    }
}
