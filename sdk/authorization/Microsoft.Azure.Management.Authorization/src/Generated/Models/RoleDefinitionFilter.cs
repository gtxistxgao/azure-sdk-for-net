// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Authorization.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Role Definitions filter
    /// </summary>
    public partial class RoleDefinitionFilter
    {
        /// <summary>
        /// Initializes a new instance of the RoleDefinitionFilter class.
        /// </summary>
        public RoleDefinitionFilter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the RoleDefinitionFilter class.
        /// </summary>
        /// <param name="roleName">Returns role definition with the specific
        /// name.</param>
        /// <param name="type">Returns role definition with the specific
        /// type.</param>
        public RoleDefinitionFilter(string roleName = default(string), string type = default(string))
        {
            RoleName = roleName;
            Type = type;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets returns role definition with the specific name.
        /// </summary>
        [JsonProperty(PropertyName = "roleName")]
        public string RoleName { get; set; }

        /// <summary>
        /// Gets or sets returns role definition with the specific type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

    }
}