// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.DataBox.Models
{
    /// <summary> Details to transfer all data. </summary>
    public partial class TransferAllDetails
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

        /// <summary> Initializes a new instance of <see cref="TransferAllDetails"/>. </summary>
        /// <param name="dataAccountType"> Type of the account of data. </param>
        public TransferAllDetails(DataAccountType dataAccountType)
        {
            DataAccountType = dataAccountType;
        }

        /// <summary> Initializes a new instance of <see cref="TransferAllDetails"/>. </summary>
        /// <param name="dataAccountType"> Type of the account of data. </param>
        /// <param name="transferAllBlobs"> To indicate if all Azure blobs have to be transferred. </param>
        /// <param name="transferAllFiles"> To indicate if all Azure Files have to be transferred. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal TransferAllDetails(DataAccountType dataAccountType, bool? transferAllBlobs, bool? transferAllFiles, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            DataAccountType = dataAccountType;
            TransferAllBlobs = transferAllBlobs;
            TransferAllFiles = transferAllFiles;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="TransferAllDetails"/> for deserialization. </summary>
        internal TransferAllDetails()
        {
        }

        /// <summary> Type of the account of data. </summary>
        public DataAccountType DataAccountType { get; set; }
        /// <summary> To indicate if all Azure blobs have to be transferred. </summary>
        public bool? TransferAllBlobs { get; set; }
        /// <summary> To indicate if all Azure Files have to be transferred. </summary>
        public bool? TransferAllFiles { get; set; }
    }
}
