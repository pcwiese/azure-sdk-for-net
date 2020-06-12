// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Threading;
using System.Threading.Tasks;
using Azure;
using Azure.Core;
using Azure.Core.Pipeline;
using Azure.Management.Network.Models;

namespace Azure.Management.Network
{
    /// <summary> The PublicIPAddresses service client. </summary>
    public partial class PublicIPAddressesOperations
    {
        private readonly ClientDiagnostics _clientDiagnostics;
        private readonly HttpPipeline _pipeline;
        internal PublicIPAddressesRestOperations RestClient { get; }
        /// <summary> Initializes a new instance of PublicIPAddressesOperations for mocking. </summary>
        protected PublicIPAddressesOperations()
        {
        }
        /// <summary> Initializes a new instance of PublicIPAddressesOperations. </summary>
        /// <param name="clientDiagnostics"> The handler for diagnostic messaging in the client. </param>
        /// <param name="pipeline"> The HTTP pipeline for sending and receiving REST requests and responses. </param>
        /// <param name="subscriptionId"> The subscription credentials which uniquely identify the Microsoft Azure subscription. The subscription ID forms part of the URI for every service call. </param>
        /// <param name="endpoint"> server parameter. </param>
        internal PublicIPAddressesOperations(ClientDiagnostics clientDiagnostics, HttpPipeline pipeline, string subscriptionId, Uri endpoint = null)
        {
            RestClient = new PublicIPAddressesRestOperations(clientDiagnostics, pipeline, subscriptionId, endpoint);
            _clientDiagnostics = clientDiagnostics;
            _pipeline = pipeline;
        }

        /// <summary> Gets the specified public IP address in a specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="publicIpAddressName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PublicIPAddress>> GetAsync(string resourceGroupName, string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.Get");
            scope.Start();
            try
            {
                return await RestClient.GetAsync(resourceGroupName, publicIpAddressName, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets the specified public IP address in a specified resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="publicIpAddressName"> The name of the subnet. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PublicIPAddress> Get(string resourceGroupName, string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.Get");
            scope.Start();
            try
            {
                return RestClient.Get(resourceGroupName, publicIpAddressName, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates public IP address tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="parameters"> Parameters supplied to update public IP address tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PublicIPAddress>> UpdateTagsAsync(string resourceGroupName, string publicIpAddressName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.UpdateTags");
            scope.Start();
            try
            {
                return await RestClient.UpdateTagsAsync(resourceGroupName, publicIpAddressName, parameters, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Updates public IP address tags. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="parameters"> Parameters supplied to update public IP address tags. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PublicIPAddress> UpdateTags(string resourceGroupName, string publicIpAddressName, TagsObject parameters, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.UpdateTags");
            scope.Start();
            try
            {
                return RestClient.UpdateTags(resourceGroupName, publicIpAddressName, parameters, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified public IP address in a virtual machine scale set. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the virtual machine scale set. </param>
        /// <param name="virtualmachineIndex"> The virtual machine index. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="ipConfigurationName"> The name of the IP configuration. </param>
        /// <param name="publicIpAddressName"> The name of the public IP Address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<Response<PublicIPAddress>> GetVirtualMachineScaleSetPublicIPAddressAsync(string resourceGroupName, string virtualMachineScaleSetName, string virtualmachineIndex, string networkInterfaceName, string ipConfigurationName, string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.GetVirtualMachineScaleSetPublicIPAddress");
            scope.Start();
            try
            {
                return await RestClient.GetVirtualMachineScaleSetPublicIPAddressAsync(resourceGroupName, virtualMachineScaleSetName, virtualmachineIndex, networkInterfaceName, ipConfigurationName, publicIpAddressName, expand, cancellationToken).ConfigureAwait(false);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Get the specified public IP address in a virtual machine scale set. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the virtual machine scale set. </param>
        /// <param name="virtualmachineIndex"> The virtual machine index. </param>
        /// <param name="networkInterfaceName"> The name of the network interface. </param>
        /// <param name="ipConfigurationName"> The name of the IP configuration. </param>
        /// <param name="publicIpAddressName"> The name of the public IP Address. </param>
        /// <param name="expand"> Expands referenced resources. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Response<PublicIPAddress> GetVirtualMachineScaleSetPublicIPAddress(string resourceGroupName, string virtualMachineScaleSetName, string virtualmachineIndex, string networkInterfaceName, string ipConfigurationName, string publicIpAddressName, string expand = null, CancellationToken cancellationToken = default)
        {
            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.GetVirtualMachineScaleSetPublicIPAddress");
            scope.Start();
            try
            {
                return RestClient.GetVirtualMachineScaleSetPublicIPAddress(resourceGroupName, virtualMachineScaleSetName, virtualmachineIndex, networkInterfaceName, ipConfigurationName, publicIpAddressName, expand, cancellationToken);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Gets all the public IP addresses in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PublicIPAddress> ListAllAsync(CancellationToken cancellationToken = default)
        {
            async Task<Page<PublicIPAddress>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.ListAll");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAllAsync(cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PublicIPAddress>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.ListAll");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAllNextPageAsync(nextLink, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all the public IP addresses in a subscription. </summary>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PublicIPAddress> ListAll(CancellationToken cancellationToken = default)
        {
            Page<PublicIPAddress> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.ListAll");
                scope.Start();
                try
                {
                    var response = RestClient.ListAll(cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PublicIPAddress> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.ListAll");
                scope.Start();
                try
                {
                    var response = RestClient.ListAllNextPage(nextLink, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all public IP addresses in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PublicIPAddress> ListAsync(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            async Task<Page<PublicIPAddress>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListAsync(resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PublicIPAddress>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.List");
                scope.Start();
                try
                {
                    var response = await RestClient.ListNextPageAsync(nextLink, resourceGroupName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets all public IP addresses in a resource group. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PublicIPAddress> List(string resourceGroupName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }

            Page<PublicIPAddress> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.List(resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PublicIPAddress> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.List");
                scope.Start();
                try
                {
                    var response = RestClient.ListNextPage(nextLink, resourceGroupName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets information about all public IP addresses on a virtual machine scale set level. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the virtual machine scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PublicIPAddress> ListVirtualMachineScaleSetPublicIPAddressesAsync(string resourceGroupName, string virtualMachineScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualMachineScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineScaleSetName));
            }

            async Task<Page<PublicIPAddress>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.ListVirtualMachineScaleSetPublicIPAddresses");
                scope.Start();
                try
                {
                    var response = await RestClient.ListVirtualMachineScaleSetPublicIPAddressesAsync(resourceGroupName, virtualMachineScaleSetName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PublicIPAddress>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.ListVirtualMachineScaleSetPublicIPAddresses");
                scope.Start();
                try
                {
                    var response = await RestClient.ListVirtualMachineScaleSetPublicIPAddressesNextPageAsync(nextLink, resourceGroupName, virtualMachineScaleSetName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets information about all public IP addresses on a virtual machine scale set level. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the virtual machine scale set. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PublicIPAddress> ListVirtualMachineScaleSetPublicIPAddresses(string resourceGroupName, string virtualMachineScaleSetName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualMachineScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineScaleSetName));
            }

            Page<PublicIPAddress> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.ListVirtualMachineScaleSetPublicIPAddresses");
                scope.Start();
                try
                {
                    var response = RestClient.ListVirtualMachineScaleSetPublicIPAddresses(resourceGroupName, virtualMachineScaleSetName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PublicIPAddress> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.ListVirtualMachineScaleSetPublicIPAddresses");
                scope.Start();
                try
                {
                    var response = RestClient.ListVirtualMachineScaleSetPublicIPAddressesNextPage(nextLink, resourceGroupName, virtualMachineScaleSetName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets information about all public IP addresses in a virtual machine IP configuration in a virtual machine scale set. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the virtual machine scale set. </param>
        /// <param name="virtualmachineIndex"> The virtual machine index. </param>
        /// <param name="networkInterfaceName"> The network interface name. </param>
        /// <param name="ipConfigurationName"> The IP configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual AsyncPageable<PublicIPAddress> ListVirtualMachineScaleSetVMPublicIPAddressesAsync(string resourceGroupName, string virtualMachineScaleSetName, string virtualmachineIndex, string networkInterfaceName, string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualMachineScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineScaleSetName));
            }
            if (virtualmachineIndex == null)
            {
                throw new ArgumentNullException(nameof(virtualmachineIndex));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }
            if (ipConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(ipConfigurationName));
            }

            async Task<Page<PublicIPAddress>> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.ListVirtualMachineScaleSetVMPublicIPAddresses");
                scope.Start();
                try
                {
                    var response = await RestClient.ListVirtualMachineScaleSetVMPublicIPAddressesAsync(resourceGroupName, virtualMachineScaleSetName, virtualmachineIndex, networkInterfaceName, ipConfigurationName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            async Task<Page<PublicIPAddress>> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.ListVirtualMachineScaleSetVMPublicIPAddresses");
                scope.Start();
                try
                {
                    var response = await RestClient.ListVirtualMachineScaleSetVMPublicIPAddressesNextPageAsync(nextLink, resourceGroupName, virtualMachineScaleSetName, virtualmachineIndex, networkInterfaceName, ipConfigurationName, cancellationToken).ConfigureAwait(false);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateAsyncEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Gets information about all public IP addresses in a virtual machine IP configuration in a virtual machine scale set. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="virtualMachineScaleSetName"> The name of the virtual machine scale set. </param>
        /// <param name="virtualmachineIndex"> The virtual machine index. </param>
        /// <param name="networkInterfaceName"> The network interface name. </param>
        /// <param name="ipConfigurationName"> The IP configuration name. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual Pageable<PublicIPAddress> ListVirtualMachineScaleSetVMPublicIPAddresses(string resourceGroupName, string virtualMachineScaleSetName, string virtualmachineIndex, string networkInterfaceName, string ipConfigurationName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (virtualMachineScaleSetName == null)
            {
                throw new ArgumentNullException(nameof(virtualMachineScaleSetName));
            }
            if (virtualmachineIndex == null)
            {
                throw new ArgumentNullException(nameof(virtualmachineIndex));
            }
            if (networkInterfaceName == null)
            {
                throw new ArgumentNullException(nameof(networkInterfaceName));
            }
            if (ipConfigurationName == null)
            {
                throw new ArgumentNullException(nameof(ipConfigurationName));
            }

            Page<PublicIPAddress> FirstPageFunc(int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.ListVirtualMachineScaleSetVMPublicIPAddresses");
                scope.Start();
                try
                {
                    var response = RestClient.ListVirtualMachineScaleSetVMPublicIPAddresses(resourceGroupName, virtualMachineScaleSetName, virtualmachineIndex, networkInterfaceName, ipConfigurationName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            Page<PublicIPAddress> NextPageFunc(string nextLink, int? pageSizeHint)
            {
                using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.ListVirtualMachineScaleSetVMPublicIPAddresses");
                scope.Start();
                try
                {
                    var response = RestClient.ListVirtualMachineScaleSetVMPublicIPAddressesNextPage(nextLink, resourceGroupName, virtualMachineScaleSetName, virtualmachineIndex, networkInterfaceName, ipConfigurationName, cancellationToken);
                    return Page.FromValues(response.Value.Value, response.Value.NextLink, response.GetRawResponse());
                }
                catch (Exception e)
                {
                    scope.Failed(e);
                    throw;
                }
            }
            return PageableHelpers.CreateEnumerable(FirstPageFunc, NextPageFunc);
        }

        /// <summary> Deletes the specified public IP address. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="publicIpAddressName"> The name of the subnet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<PublicIPAddressesDeleteOperation> StartDeleteAsync(string resourceGroupName, string publicIpAddressName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (publicIpAddressName == null)
            {
                throw new ArgumentNullException(nameof(publicIpAddressName));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.DeleteAsync(resourceGroupName, publicIpAddressName, cancellationToken).ConfigureAwait(false);
                return new PublicIPAddressesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, publicIpAddressName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Deletes the specified public IP address. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="publicIpAddressName"> The name of the subnet. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PublicIPAddressesDeleteOperation StartDelete(string resourceGroupName, string publicIpAddressName, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (publicIpAddressName == null)
            {
                throw new ArgumentNullException(nameof(publicIpAddressName));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.StartDelete");
            scope.Start();
            try
            {
                var originalResponse = RestClient.Delete(resourceGroupName, publicIpAddressName, cancellationToken);
                return new PublicIPAddressesDeleteOperation(_clientDiagnostics, _pipeline, RestClient.CreateDeleteRequest(resourceGroupName, publicIpAddressName).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a static or dynamic public IP address. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="parameters"> Parameters supplied to the create or update public IP address operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual async Task<PublicIPAddressesCreateOrUpdateOperation> StartCreateOrUpdateAsync(string resourceGroupName, string publicIpAddressName, PublicIPAddress parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (publicIpAddressName == null)
            {
                throw new ArgumentNullException(nameof(publicIpAddressName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = await RestClient.CreateOrUpdateAsync(resourceGroupName, publicIpAddressName, parameters, cancellationToken).ConfigureAwait(false);
                return new PublicIPAddressesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, publicIpAddressName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }

        /// <summary> Creates or updates a static or dynamic public IP address. </summary>
        /// <param name="resourceGroupName"> The name of the resource group. </param>
        /// <param name="publicIpAddressName"> The name of the public IP address. </param>
        /// <param name="parameters"> Parameters supplied to the create or update public IP address operation. </param>
        /// <param name="cancellationToken"> The cancellation token to use. </param>
        public virtual PublicIPAddressesCreateOrUpdateOperation StartCreateOrUpdate(string resourceGroupName, string publicIpAddressName, PublicIPAddress parameters, CancellationToken cancellationToken = default)
        {
            if (resourceGroupName == null)
            {
                throw new ArgumentNullException(nameof(resourceGroupName));
            }
            if (publicIpAddressName == null)
            {
                throw new ArgumentNullException(nameof(publicIpAddressName));
            }
            if (parameters == null)
            {
                throw new ArgumentNullException(nameof(parameters));
            }

            using var scope = _clientDiagnostics.CreateScope("PublicIPAddressesOperations.StartCreateOrUpdate");
            scope.Start();
            try
            {
                var originalResponse = RestClient.CreateOrUpdate(resourceGroupName, publicIpAddressName, parameters, cancellationToken);
                return new PublicIPAddressesCreateOrUpdateOperation(_clientDiagnostics, _pipeline, RestClient.CreateCreateOrUpdateRequest(resourceGroupName, publicIpAddressName, parameters).Request, originalResponse);
            }
            catch (Exception e)
            {
                scope.Failed(e);
                throw;
            }
        }
    }
}