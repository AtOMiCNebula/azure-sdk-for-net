// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.ResourceManager.Sql.Models;

namespace Azure.ResourceManager.Sql
{
    /// <summary> Sets a database&apos;s long term retention policy. </summary>
    public partial class BackupLongTermRetentionPoliciesCreateOrUpdateOperation : Operation<BackupLongTermRetentionPolicy>, IOperationSource<BackupLongTermRetentionPolicy>
    {
        private readonly ArmOperationHelpers<BackupLongTermRetentionPolicy> _operation;
        internal BackupLongTermRetentionPoliciesCreateOrUpdateOperation(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, Request request, Response response)
        {
            _operation = new ArmOperationHelpers<BackupLongTermRetentionPolicy>(this, clientDiagnostics, pipeline, request, response, OperationFinalStateVia.Location, "BackupLongTermRetentionPoliciesCreateOrUpdateOperation");
        }
        /// <inheritdoc />
        public override string Id => _operation.Id;

        /// <inheritdoc />
        public override BackupLongTermRetentionPolicy Value => _operation.Value;

        /// <inheritdoc />
        public override bool HasCompleted => _operation.HasCompleted;

        /// <inheritdoc />
        public override bool HasValue => _operation.HasValue;

        /// <inheritdoc />
        public override Response GetRawResponse() => _operation.GetRawResponse();

        /// <inheritdoc />
        public override Response UpdateStatus(CancellationToken cancellationToken = default) => _operation.UpdateStatus(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response> UpdateStatusAsync(CancellationToken cancellationToken = default) => _operation.UpdateStatusAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<BackupLongTermRetentionPolicy>> WaitForCompletionAsync(CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(cancellationToken);

        /// <inheritdoc />
        public override ValueTask<Response<BackupLongTermRetentionPolicy>> WaitForCompletionAsync(TimeSpan pollingInterval, CancellationToken cancellationToken = default) => _operation.WaitForCompletionAsync(pollingInterval, cancellationToken);

        BackupLongTermRetentionPolicy IOperationSource<BackupLongTermRetentionPolicy>.CreateResult(Response response, CancellationToken cancellationToken)
        {
            using var document = JsonDocument.Parse(response.ContentStream);
            return BackupLongTermRetentionPolicy.DeserializeBackupLongTermRetentionPolicy(document.RootElement);
        }

        async ValueTask<BackupLongTermRetentionPolicy> IOperationSource<BackupLongTermRetentionPolicy>.CreateResultAsync(Response response, CancellationToken cancellationToken)
        {
            using var document = await JsonDocument.ParseAsync(response.ContentStream, default, cancellationToken).ConfigureAwait(false);
            return BackupLongTermRetentionPolicy.DeserializeBackupLongTermRetentionPolicy(document.RootElement);
        }
    }
}
