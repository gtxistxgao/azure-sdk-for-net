// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.EdgeGateway.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Represents the networkAdapter on a device.
    /// </summary>
    public partial class NetworkAdapter
    {
        /// <summary>
        /// Initializes a new instance of the NetworkAdapter class.
        /// </summary>
        public NetworkAdapter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the NetworkAdapter class.
        /// </summary>
        /// <param name="adapterId">Instance ID of network adapter.</param>
        /// <param name="adapterPosition">Hardware position of network
        /// adapter.</param>
        /// <param name="index">Logical index of the adapter.</param>
        /// <param name="nodeId">Node ID of the network adapter.</param>
        /// <param name="networkAdapterName">Network adapter name.</param>
        /// <param name="label">Hardware label for the adapter.</param>
        /// <param name="macAddress">MAC address.</param>
        /// <param name="linkSpeed">Link speed.</param>
        /// <param name="status">Value indicating whether this adapter is
        /// valid. Possible values include: 'Inactive', 'Active'</param>
        /// <param name="rdmaStatus">Value indicating whether this adapter is
        /// RDMA capable. Possible values include: 'Incapable',
        /// 'Capable'</param>
        /// <param name="dhcpStatus">Value indicating whether this adapter has
        /// DHCP enabled. Possible values include: 'Disabled',
        /// 'Enabled'</param>
        /// <param name="ipv4Configuration">The IPv4 configuration of the
        /// network adapter.</param>
        /// <param name="ipv6Configuration">The IPv6 configuration of the
        /// network adapter.</param>
        /// <param name="ipv6LinkLocalAddress">The IPv6 local address.</param>
        /// <param name="dnsServers">The list of DNS Servers of the
        /// device.</param>
        public NetworkAdapter(string adapterId = default(string), NetworkAdapterPosition adapterPosition = default(NetworkAdapterPosition), int? index = default(int?), string nodeId = default(string), string networkAdapterName = default(string), string label = default(string), string macAddress = default(string), long? linkSpeed = default(long?), string status = default(string), string rdmaStatus = default(string), string dhcpStatus = default(string), Ipv4Config ipv4Configuration = default(Ipv4Config), Ipv6Config ipv6Configuration = default(Ipv6Config), string ipv6LinkLocalAddress = default(string), IList<string> dnsServers = default(IList<string>))
        {
            AdapterId = adapterId;
            AdapterPosition = adapterPosition;
            Index = index;
            NodeId = nodeId;
            NetworkAdapterName = networkAdapterName;
            Label = label;
            MacAddress = macAddress;
            LinkSpeed = linkSpeed;
            Status = status;
            RdmaStatus = rdmaStatus;
            DhcpStatus = dhcpStatus;
            Ipv4Configuration = ipv4Configuration;
            Ipv6Configuration = ipv6Configuration;
            Ipv6LinkLocalAddress = ipv6LinkLocalAddress;
            DnsServers = dnsServers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets instance ID of network adapter.
        /// </summary>
        [JsonProperty(PropertyName = "adapterId")]
        public string AdapterId { get; private set; }

        /// <summary>
        /// Gets hardware position of network adapter.
        /// </summary>
        [JsonProperty(PropertyName = "adapterPosition")]
        public NetworkAdapterPosition AdapterPosition { get; private set; }

        /// <summary>
        /// Gets logical index of the adapter.
        /// </summary>
        [JsonProperty(PropertyName = "index")]
        public int? Index { get; private set; }

        /// <summary>
        /// Gets node ID of the network adapter.
        /// </summary>
        [JsonProperty(PropertyName = "nodeId")]
        public string NodeId { get; private set; }

        /// <summary>
        /// Gets network adapter name.
        /// </summary>
        [JsonProperty(PropertyName = "networkAdapterName")]
        public string NetworkAdapterName { get; private set; }

        /// <summary>
        /// Gets hardware label for the adapter.
        /// </summary>
        [JsonProperty(PropertyName = "label")]
        public string Label { get; private set; }

        /// <summary>
        /// Gets MAC address.
        /// </summary>
        [JsonProperty(PropertyName = "macAddress")]
        public string MacAddress { get; private set; }

        /// <summary>
        /// Gets link speed.
        /// </summary>
        [JsonProperty(PropertyName = "linkSpeed")]
        public long? LinkSpeed { get; private set; }

        /// <summary>
        /// Gets value indicating whether this adapter is valid. Possible
        /// values include: 'Inactive', 'Active'
        /// </summary>
        [JsonProperty(PropertyName = "status")]
        public string Status { get; private set; }

        /// <summary>
        /// Gets or sets value indicating whether this adapter is RDMA capable.
        /// Possible values include: 'Incapable', 'Capable'
        /// </summary>
        [JsonProperty(PropertyName = "rdmaStatus")]
        public string RdmaStatus { get; set; }

        /// <summary>
        /// Gets or sets value indicating whether this adapter has DHCP
        /// enabled. Possible values include: 'Disabled', 'Enabled'
        /// </summary>
        [JsonProperty(PropertyName = "dhcpStatus")]
        public string DhcpStatus { get; set; }

        /// <summary>
        /// Gets the IPv4 configuration of the network adapter.
        /// </summary>
        [JsonProperty(PropertyName = "ipv4Configuration")]
        public Ipv4Config Ipv4Configuration { get; private set; }

        /// <summary>
        /// Gets the IPv6 configuration of the network adapter.
        /// </summary>
        [JsonProperty(PropertyName = "ipv6Configuration")]
        public Ipv6Config Ipv6Configuration { get; private set; }

        /// <summary>
        /// Gets the IPv6 local address.
        /// </summary>
        [JsonProperty(PropertyName = "ipv6LinkLocalAddress")]
        public string Ipv6LinkLocalAddress { get; private set; }

        /// <summary>
        /// Gets the list of DNS Servers of the device.
        /// </summary>
        [JsonProperty(PropertyName = "dnsServers")]
        public IList<string> DnsServers { get; private set; }

    }
}
