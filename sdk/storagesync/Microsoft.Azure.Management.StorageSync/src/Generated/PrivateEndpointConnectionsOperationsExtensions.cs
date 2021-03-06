// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.StorageSync
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.Collections;
    using System.Collections.Generic;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for PrivateEndpointConnectionsOperations.
    /// </summary>
    public static partial class PrivateEndpointConnectionsOperationsExtensions
    {
            /// <summary>
            /// Gets the specified private endpoint connection associated with the storage
            /// sync service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// The name of the storage sync service name within the specified resource
            /// group.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            public static PrivateEndpointConnection Get(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string storageSyncServiceName, string privateEndpointConnectionName)
            {
                return operations.GetAsync(resourceGroupName, storageSyncServiceName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the specified private endpoint connection associated with the storage
            /// sync service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// The name of the storage sync service name within the specified resource
            /// group.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> GetAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string storageSyncServiceName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the storage sync service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// The name of the storage sync service name within the specified resource
            /// group.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='properties'>
            /// The private endpoint connection properties.
            /// </param>
            public static PrivateEndpointConnection Create(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string storageSyncServiceName, string privateEndpointConnectionName, PrivateEndpointConnection properties)
            {
                return operations.CreateAsync(resourceGroupName, storageSyncServiceName, privateEndpointConnectionName, properties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the storage sync service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// The name of the storage sync service name within the specified resource
            /// group.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='properties'>
            /// The private endpoint connection properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> CreateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string storageSyncServiceName, string privateEndpointConnectionName, PrivateEndpointConnection properties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.CreateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, privateEndpointConnectionName, properties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the
            /// storage sync service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// The name of the storage sync service name within the specified resource
            /// group.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            public static PrivateEndpointConnectionsDeleteHeaders Delete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string storageSyncServiceName, string privateEndpointConnectionName)
            {
                return operations.DeleteAsync(resourceGroupName, storageSyncServiceName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the
            /// storage sync service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// The name of the storage sync service name within the specified resource
            /// group.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnectionsDeleteHeaders> DeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string storageSyncServiceName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Get a PrivateEndpointConnection List.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            public static IEnumerable<PrivateEndpointConnection> ListByStorageSyncService(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string storageSyncServiceName)
            {
                return operations.ListByStorageSyncServiceAsync(resourceGroupName, storageSyncServiceName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Get a PrivateEndpointConnection List.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// Name of Storage Sync Service resource.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IEnumerable<PrivateEndpointConnection>> ListByStorageSyncServiceAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string storageSyncServiceName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListByStorageSyncServiceWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the storage sync service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// The name of the storage sync service name within the specified resource
            /// group.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='properties'>
            /// The private endpoint connection properties.
            /// </param>
            public static PrivateEndpointConnection BeginCreate(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string storageSyncServiceName, string privateEndpointConnectionName, PrivateEndpointConnection properties)
            {
                return operations.BeginCreateAsync(resourceGroupName, storageSyncServiceName, privateEndpointConnectionName, properties).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Update the state of specified private endpoint connection associated with
            /// the storage sync service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// The name of the storage sync service name within the specified resource
            /// group.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='properties'>
            /// The private endpoint connection properties.
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnection> BeginCreateAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string storageSyncServiceName, string privateEndpointConnectionName, PrivateEndpointConnection properties, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginCreateWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, privateEndpointConnectionName, properties, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the
            /// storage sync service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// The name of the storage sync service name within the specified resource
            /// group.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            public static PrivateEndpointConnectionsDeleteHeaders BeginDelete(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string storageSyncServiceName, string privateEndpointConnectionName)
            {
                return operations.BeginDeleteAsync(resourceGroupName, storageSyncServiceName, privateEndpointConnectionName).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified private endpoint connection associated with the
            /// storage sync service.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='resourceGroupName'>
            /// The name of the resource group. The name is case insensitive.
            /// </param>
            /// <param name='storageSyncServiceName'>
            /// The name of the storage sync service name within the specified resource
            /// group.
            /// </param>
            /// <param name='privateEndpointConnectionName'>
            /// The name of the private endpoint connection associated with the Azure
            /// resource
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<PrivateEndpointConnectionsDeleteHeaders> BeginDeleteAsync(this IPrivateEndpointConnectionsOperations operations, string resourceGroupName, string storageSyncServiceName, string privateEndpointConnectionName, CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.BeginDeleteWithHttpMessagesAsync(resourceGroupName, storageSyncServiceName, privateEndpointConnectionName, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

    }
}
