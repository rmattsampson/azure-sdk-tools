﻿// ----------------------------------------------------------------------------------
//
// Copyright Microsoft Corporation
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// ----------------------------------------------------------------------------------

namespace Microsoft.WindowsAzure.Commands.Test.Subscription
{
    using System.Management.Automation;
    using Commands.Utilities.Common;
    using Commands.Subscription;
    using Moq;
    using VisualStudio.TestTools.UnitTesting;

    [TestClass]
    public class SelectAzureSubscriptionTests
    {
        [TestMethod]
        public void CleansDefaultSubscriptionTwice()
        {
            // Setup
            Mock<ICommandRuntime> commandRuntimeMock = new Mock<ICommandRuntime>();
            SelectAzureSubscriptionCommand cmdlet = new SelectAzureSubscriptionCommand()
            {
                CommandRuntime = commandRuntimeMock.Object,
                PassThru = true,
                NoDefault = true
            };

            // Test
            cmdlet.ExecuteCmdlet();
            cmdlet.ExecuteCmdlet();

            // Assert that no exception is thrown
            Assert.IsTrue(true);
        }
    }
}