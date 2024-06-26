// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> The Network Adapter configuration of a DataBox. </summary>
    public partial class ApplianceNetworkConfiguration
    {
        /// <summary>
        /// Keeps track of any properties unknown to the library.
        /// <para>
        /// To assign an object to the value of this property use <see cref="BinaryData.FromObjectAsJson{T}(T, System.Text.Json.JsonSerializerOptions?)"/>.
        /// </para>
        /// <para>
        /// To assign an already formatted json string to this property use <see cref="BinaryData.FromString(string)"/>.
        /// </para>
        /// <para>
        /// Examples:
        /// <list type="bullet">
        /// <item>
        /// <term>BinaryData.FromObjectAsJson("foo")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("\"foo\"")</term>
        /// <description>Creates a payload of "foo".</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromObjectAsJson(new { key = "value" })</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// <item>
        /// <term>BinaryData.FromString("{\"key\": \"value\"}")</term>
        /// <description>Creates a payload of { "key": "value" }.</description>
        /// </item>
        /// </list>
        /// </para>
        /// </summary>
        private IDictionary<string, BinaryData> _serializedAdditionalRawData;

        /// <summary> Initializes a new instance of <see cref="ApplianceNetworkConfiguration"/>. </summary>
        internal ApplianceNetworkConfiguration()
        {
        }

        /// <summary> Initializes a new instance of <see cref="ApplianceNetworkConfiguration"/>. </summary>
        /// <param name="name"> Name of the network. </param>
        /// <param name="macAddress"> Mac Address. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal ApplianceNetworkConfiguration(string name, string macAddress, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            Name = name;
            MacAddress = macAddress;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Name of the network. </summary>
        public string Name { get; }
        /// <summary> Mac Address. </summary>
        public string MacAddress { get; }
    }
}
