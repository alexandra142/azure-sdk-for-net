// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Peering.Models
{
    /// <summary> The properties that define a peering bandwidth offer. </summary>
    public partial class PeeringBandwidthOffer
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

        /// <summary> Initializes a new instance of <see cref="PeeringBandwidthOffer"/>. </summary>
        public PeeringBandwidthOffer()
        {
        }

        /// <summary> Initializes a new instance of <see cref="PeeringBandwidthOffer"/>. </summary>
        /// <param name="offerName"> The name of the bandwidth offer. </param>
        /// <param name="valueInMbps"> The value of the bandwidth offer in Mbps. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal PeeringBandwidthOffer(string offerName, int? valueInMbps, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            OfferName = offerName;
            ValueInMbps = valueInMbps;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> The name of the bandwidth offer. </summary>
        public string OfferName { get; set; }
        /// <summary> The value of the bandwidth offer in Mbps. </summary>
        public int? ValueInMbps { get; set; }
    }
}
