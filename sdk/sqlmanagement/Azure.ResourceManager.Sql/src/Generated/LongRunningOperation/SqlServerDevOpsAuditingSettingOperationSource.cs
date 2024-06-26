// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;

namespace Azure.ResourceManager.Sql
{
    internal class SqlServerDevOpsAuditingSettingOperationSource : IOperationSource<SqlServerDevOpsAuditingSettingResource>
    {
        private readonly ArmClient _client;

        internal SqlServerDevOpsAuditingSettingOperationSource(ArmClient client)
        {
            _client = client;
        }

        SqlServerDevOpsAuditingSettingResource IOperationSource<SqlServerDevOpsAuditingSettingResource>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            var data = SqlServerDevOpsAuditingSettingData.DeserializeSqlServerDevOpsAuditingSettingData(document.RootElement);
            return new SqlServerDevOpsAuditingSettingResource(_client, data);
        }

        async ValueTask<SqlServerDevOpsAuditingSettingResource> IOperationSource<SqlServerDevOpsAuditingSettingResource>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            var data = SqlServerDevOpsAuditingSettingData.DeserializeSqlServerDevOpsAuditingSettingData(document.RootElement);
            return new SqlServerDevOpsAuditingSettingResource(_client, data);
        }
    }
}
