// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.RecoveryServices.SiteRecovery.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.RecoveryServices;
    using Microsoft.Azure.Management.RecoveryServices.SiteRecovery;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;
    using System.Runtime;
    using System.Runtime.Serialization;

    /// <summary>
    /// Defines values for SetMultiVmSyncStatus.
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SetMultiVmSyncStatus
    {
        [EnumMember(Value = "Enable")]
        Enable,
        [EnumMember(Value = "Disable")]
        Disable
    }
    internal static class SetMultiVmSyncStatusEnumExtension
    {
        internal static string ToSerializedValue(this SetMultiVmSyncStatus? value)  =>
            value == null ? null : ((SetMultiVmSyncStatus)value).ToSerializedValue();

        internal static string ToSerializedValue(this SetMultiVmSyncStatus value)
        {
            switch( value )
            {
                case SetMultiVmSyncStatus.Enable:
                    return "Enable";
                case SetMultiVmSyncStatus.Disable:
                    return "Disable";
            }
            return null;
        }

        internal static SetMultiVmSyncStatus? ParseSetMultiVmSyncStatus(this string value)
        {
            switch( value )
            {
                case "Enable":
                    return SetMultiVmSyncStatus.Enable;
                case "Disable":
                    return SetMultiVmSyncStatus.Disable;
            }
            return null;
        }
    }
}
