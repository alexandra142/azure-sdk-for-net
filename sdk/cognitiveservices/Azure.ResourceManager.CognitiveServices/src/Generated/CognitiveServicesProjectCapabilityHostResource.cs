// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Globalization;
using System.Threading;
using System.Threading.Tasks;
using Azure.Core;
using Azure.Core.Pipeline;

namespace Azure.ResourceManager.CognitiveServices
{
    /// <summary>
    /// A Class representing a CognitiveServicesProjectCapabilityHost along with the instance operations that can be performed on it.
    /// If you have a <see cref="ResourceIdentifier"/> you can construct a <see cref="CognitiveServicesProjectCapabilityHostResource"/>
    /// from an instance of <see cref="ArmClient"/> using the GetCognitiveServicesProjectCapabilityHostResource method.
    /// Otherwise you can get one from its parent resource <see cref="CognitiveServicesProjectResource"/> using the GetCognitiveServicesProjectCapabilityHost method.
    /// </summary>
    public partial class CognitiveServicesProjectCapabilityHostResource : ArmResource
    {
        /// <summary> Generate the resource identifier of a <see cref="CognitiveServicesProjectCapabilityHostResource"/> instance. </summary>
        /// <param name="subscriptionId"> The subscriptionId. </param>
        /// <param name="resourceGroupName"> The resourceGroupName. </param>
        /// <param name="accountName"> The accountName. </param>
        /// <param name="projectName"> The projectName. </param>
        /// <param name="capabilityHostName"> The capabilityHostName. </param>
        public static ResourceIdentifier CreateResourceIdentifier(string subscriptionId, string resourceGroupName, string accountName, string projectName, string capabilityHostName)
        {
            var resourceId = $"/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}";
            return new ResourceIdentifier(resourceId);
        }

        private readonly ClientDiagnostics _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics;
        private readonly ProjectCapabilityHostsRestOperations _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient;
        private readonly CognitiveServicesCapabilityHostData _data;

        /// <summary> Gets the resource type for the operations. </summary>
        public static readonly ResourceType ResourceType = "Microsoft.CognitiveServices/accounts/projects/capabilityHosts";

        /// <summary> Initializes a new instance of the <see cref="CognitiveServicesProjectCapabilityHostResource"/> class for mocking. </summary>
        protected CognitiveServicesProjectCapabilityHostResource()
        {
        }

        /// <summary> Initializes a new instance of the <see cref="CognitiveServicesProjectCapabilityHostResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="data"> The resource that is the target of operations. </param>
        internal CognitiveServicesProjectCapabilityHostResource(ArmClient client, CognitiveServicesCapabilityHostData data) : this(client, data.Id)
        {
            HasData = true;
            _data = data;
        }

        /// <summary> Initializes a new instance of the <see cref="CognitiveServicesProjectCapabilityHostResource"/> class. </summary>
        /// <param name="client"> The client parameters to use in these operations. </param>
        /// <param name="id"> The identifier of the resource that is the target of operations. </param>
        internal CognitiveServicesProjectCapabilityHostResource(ArmClient client, ResourceIdentifier id) : base(client, id)
        {
            _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics = new ClientDiagnostics("Azure.ResourceManager.CognitiveServices", ResourceType.Namespace, Diagnostics);
            TryGetApiVersion(ResourceType, out string cognitiveServicesProjectCapabilityHostProjectCapabilityHostsApiVersion);
            _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient = new ProjectCapabilityHostsRestOperations(Pipeline, Diagnostics.ApplicationId, Endpoint, cognitiveServicesProjectCapabilityHostProjectCapabilityHostsApiVersion);
#if DEBUG
			ValidateResourceId(Id);
#endif
        }

        /// <summary> Gets whether or not the current instance has data. </summary>
        public virtual bool HasData { get; }

        /// <summary> Gets the data representing this Feature. </summary>
        /// <exception cref="InvalidOperationException"> Throws if there is no data loaded in the current instance. </exception>
        public virtual CognitiveServicesCapabilityHostData Data
        {
            get
            {
                if (!HasData)
                    throw new InvalidOperationException("The current instance does not have data, you must call Get first.");
                return _data;
            }
        }

        internal static void ValidateResourceId(ResourceIdentifier id)
        {
            if (id.ResourceType != ResourceType)
                throw new ArgumentException(string.Format(CultureInfo.CurrentCulture, "Invalid resource type {0} expected {1}", id.ResourceType, ResourceType), nameof(id));
        }

        /// <summary>
        /// Get project capabilityHost.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectCapabilityHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesProjectCapabilityHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<CognitiveServicesProjectCapabilityHostResource>> GetAsync(CancellationToken cancellationToken = default)
        {
            using var scope = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics.CreateScope("CognitiveServicesProjectCapabilityHostResource.Get");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.GetAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CognitiveServicesProjectCapabilityHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Get project capabilityHost.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectCapabilityHosts_Get</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesProjectCapabilityHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<CognitiveServicesProjectCapabilityHostResource> Get(CancellationToken cancellationToken = default)
        {
            using var scope = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics.CreateScope("CognitiveServicesProjectCapabilityHostResource.Get");
            scope.Start();
            try
            {
                var response = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.Get(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                if (response.Value == null)
                    throw new RequestFailedException(response.GetRawResponse());
                return Response.FromValue(new CognitiveServicesProjectCapabilityHostResource(Client, response.Value), response.GetRawResponse());
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete project capabilityHost.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectCapabilityHosts_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesProjectCapabilityHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<ArmOperation> DeleteAsync(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics.CreateScope("CognitiveServicesProjectCapabilityHostResource.Delete");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.DeleteAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken).ConfigureAwait(false);
                var operation = new CognitiveServicesArmOperation(_cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics, Pipeline, _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionResponseAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Delete project capabilityHost.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectCapabilityHosts_Delete</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesProjectCapabilityHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual ArmOperation Delete(WaitUntil waitUntil, CancellationToken cancellationToken = default)
        {
            using var scope = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics.CreateScope("CognitiveServicesProjectCapabilityHostResource.Delete");
            scope.Start();
            try
            {
                var response = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.Delete(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, cancellationToken);
                var operation = new CognitiveServicesArmOperation(_cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics, Pipeline, _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.CreateDeleteRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name).Request, response, OperationFinalStateVia.Location);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletionResponse(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update project capabilityHost.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectCapabilityHosts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesProjectCapabilityHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> CapabilityHost definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual async Task<ArmOperation<CognitiveServicesProjectCapabilityHostResource>> UpdateAsync(WaitUntil waitUntil, CognitiveServicesCapabilityHostData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics.CreateScope("CognitiveServicesProjectCapabilityHostResource.Update");
            scope.Start();
            try
            {
                var response = await _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.CreateOrUpdateAsync(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken).ConfigureAwait(false);
                var operation = new CognitiveServicesArmOperation<CognitiveServicesProjectCapabilityHostResource>(new CognitiveServicesProjectCapabilityHostOperationSource(Client), _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics, Pipeline, _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
                if (waitUntil == WaitUntil.Completed)
                    await operation.WaitForCompletionAsync(cancellationToken).ConfigureAwait(false);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary>
        /// Create or update project capabilityHost.
        /// <list type="bullet">
        /// <item>
        /// <term>Request Path</term>
        /// <description>/subscriptions/{subscriptionId}/resourceGroups/{resourceGroupName}/providers/Microsoft.CognitiveServices/accounts/{accountName}/projects/{projectName}/capabilityHosts/{capabilityHostName}</description>
        /// </item>
        /// <item>
        /// <term>Operation Id</term>
        /// <description>ProjectCapabilityHosts_CreateOrUpdate</description>
        /// </item>
        /// <item>
        /// <term>Default Api Version</term>
        /// <description>2025-06-01</description>
        /// </item>
        /// <item>
        /// <term>Resource</term>
        /// <description><see cref="CognitiveServicesProjectCapabilityHostResource"/></description>
        /// </item>
        /// </list>
        /// </summary>
        /// <param name="waitUntil"> <see cref="WaitUntil.Completed"/> if the method should wait to return until the long-running operation has completed on the service; <see cref="WaitUntil.Started"/> if it should return after starting the operation. For more information on long-running operations, please see <see href="https://github.com/Azure/azure-sdk-for-net/blob/main/sdk/core/Azure.Core/samples/LongRunningOperations.md"> Azure.Core Long-Running Operation samples</see>. </param>
        /// <param name="data"> CapabilityHost definition. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        /// <exception cref="ArgumentNullException"> <paramref name="data"/> is null. </exception>
        public virtual ArmOperation<CognitiveServicesProjectCapabilityHostResource> Update(WaitUntil waitUntil, CognitiveServicesCapabilityHostData data, CancellationToken cancellationToken = default)
        {
            Argument.AssertNotNull(data, nameof(data));

            using var scope = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics.CreateScope("CognitiveServicesProjectCapabilityHostResource.Update");
            scope.Start();
            try
            {
                var response = _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.CreateOrUpdate(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data, cancellationToken);
                var operation = new CognitiveServicesArmOperation<CognitiveServicesProjectCapabilityHostResource>(new CognitiveServicesProjectCapabilityHostOperationSource(Client), _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsClientDiagnostics, Pipeline, _cognitiveServicesProjectCapabilityHostProjectCapabilityHostsRestClient.CreateCreateOrUpdateRequest(Id.SubscriptionId, Id.ResourceGroupName, Id.Parent.Parent.Name, Id.Parent.Name, Id.Name, data).Request, response, OperationFinalStateVia.OriginalUri);
                if (waitUntil == WaitUntil.Completed)
                    operation.WaitForCompletion(cancellationToken);
                return operation;
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}
