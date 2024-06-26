// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;

namespace Azure.ResourceManager.Media.Models
{
    /// <summary> The AccountEncryption. </summary>
    public partial class AccountEncryption
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

        /// <summary> Initializes a new instance of <see cref="AccountEncryption"/>. </summary>
        /// <param name="keyType"> The type of key used to encrypt the Account Key. </param>
        public AccountEncryption(AccountEncryptionKeyType keyType)
        {
            KeyType = keyType;
        }

        /// <summary> Initializes a new instance of <see cref="AccountEncryption"/>. </summary>
        /// <param name="keyType"> The type of key used to encrypt the Account Key. </param>
        /// <param name="keyVaultProperties"> The properties of the key used to encrypt the account. </param>
        /// <param name="identity"> The Key Vault identity. </param>
        /// <param name="status"> The current status of the Key Vault mapping. </param>
        /// <param name="serializedAdditionalRawData"> Keeps track of any properties unknown to the library. </param>
        internal AccountEncryption(AccountEncryptionKeyType keyType, KeyVaultProperties keyVaultProperties, ResourceIdentity identity, string status, IDictionary<string, BinaryData> serializedAdditionalRawData)
        {
            KeyType = keyType;
            KeyVaultProperties = keyVaultProperties;
            Identity = identity;
            Status = status;
            _serializedAdditionalRawData = serializedAdditionalRawData;
        }

        /// <summary> Initializes a new instance of <see cref="AccountEncryption"/> for deserialization. </summary>
        internal AccountEncryption()
        {
        }

        /// <summary> The type of key used to encrypt the Account Key. </summary>
        public AccountEncryptionKeyType KeyType { get; set; }
        /// <summary> The properties of the key used to encrypt the account. </summary>
        public KeyVaultProperties KeyVaultProperties { get; set; }
        /// <summary> The Key Vault identity. </summary>
        public ResourceIdentity Identity { get; set; }
        /// <summary> The current status of the Key Vault mapping. </summary>
        public string Status { get; }
    }
}
