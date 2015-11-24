﻿//
// Copyright (c) Microsoft.  All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System;
using System.Linq;
using Microsoft.Azure.Management.Intune.Tests.Helpers;
using Microsoft.Rest.ClientRuntime.Azure.TestFramework;
using Xunit;
using Microsoft.Azure.Test.HttpRecorder;

namespace Microsoft.Azure.Management.Intune.Tests.ScenarioTests
{
    public class FlaggedUserScenarioTests : TestBase
    {
        /// <summary>
        /// Test class for Flagged user operations.
        /// </summary>
        static FlaggedUserScenarioTests()
        {
            IntuneClientHelper.InitializeEnvironment();
        }

        /// <summary>
        /// Verifies that Get default statuses works
        /// </summary>
        [Fact]
        public void ShouldGetDefaultStatuses()
        {
            using (MockContext context = MockContext.Start())
            {
                var client = IntuneClientHelper.GetIntuneResourceManagementClient(context);
                var defaultStatus = client.GetMAMStatuses(IntuneClientHelper.AsuHostName);
                Assert.Equal("default", defaultStatus.Name);
                Assert.Equal("complete", defaultStatus.Status);
                Assert.Equal("Microsoft.Intune/locations/statuses", defaultStatus.Type);                
            }
        }

        /// <summary>
        /// Verifies that Get flagged users works
        /// </summary>
        [Fact]
        public void ShouldGetFlaggedUsers()
        {
            using (MockContext context = MockContext.Start())
            {
                var client = IntuneClientHelper.GetIntuneResourceManagementClient(context);
                var flaggedUsers = client.GetMAMFlaggedUsers(IntuneClientHelper.AsuHostName).ToList();
                
                Assert.True(flaggedUsers.Count > 0, "Zero flagged users");
                Assert.Equal("Microsoft.Intune/locations/flaggedUsers", flaggedUsers[0].Type);
                Assert.True(flaggedUsers[0].ErrorCount > 0, "Zero errors for the flagged user");
                Assert.NotNull(flaggedUsers[0].FriendlyName);
                Assert.NotNull(flaggedUsers[0].Id);
                Assert.NotNull(flaggedUsers[0].Name);                
            }
        }


        /// <summary>
        /// Verifies that Get flagged devices works
        /// </summary>
        [Fact]
        public void ShouldGetFlaggedDevices()
        {
            using (MockContext context = MockContext.Start())
            {
                var client = IntuneClientHelper.GetIntuneResourceManagementClient(context);
                var flaggedUsers = client.GetMAMFlaggedUsers(IntuneClientHelper.AsuHostName).ToList();
                Assert.True(flaggedUsers.Count > 0, "Zero flagged users");

                var flaggedDevices = client.GetMAMUserDevices(IntuneClientHelper.AsuHostName, flaggedUsers[0].Name).ToList();
                Assert.True(flaggedDevices.Count > 0, "Zero flagged devices");

                Assert.Equal("Microsoft.Intune/locations/users/devices", flaggedDevices[0].Type);
                Assert.NotNull(flaggedDevices[0].Name);
                Assert.NotNull(flaggedDevices[0].FriendlyName);
                Assert.NotNull(flaggedDevices[0].Platform);
                Assert.NotNull(flaggedDevices[0].PlatformVersion);
                Assert.NotNull(flaggedDevices[0].UserId);
                Assert.NotNull(flaggedDevices[0].Id);
            }
        }
    }
}