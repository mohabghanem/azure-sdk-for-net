// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Compute.Fluent
{

    using Microsoft.Azure.Management.Storage.Fluent.Models;
    using Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.Compute.Fluent.Models;
    using Microsoft.Azure.Management.Network.Fluent.Models;
    using Microsoft.Azure.Management.Resource.Fluent.Core;
    using Microsoft.Azure.Management.Resource.Fluent;
    using System.Threading;
    internal partial class VirtualMachineScaleSetsImpl 
    {
        /// <summary>
        /// Begins a definition for a new resource.
        /// <p>
        /// This is the beginning of the builder pattern used to create top level resources
        /// in Azure. The final method completing the definition and starting the actual resource creation
        /// process in Azure is {@link Creatable#create()}.
        /// <p>
        /// Note that the {@link Creatable#create()} method is
        /// only available at the stage of the resource definition that has the minimum set of input
        /// parameters specified. If you do not see {@link Creatable#create()} among the available methods, it
        /// means you have not yet specified all the required input settings. Input settings generally begin
        /// with the word "with", for example: <code>.withNewResourceGroup()</code> and return the next stage
        /// of the resource definition, as an interface in the "fluent interface" style.
        /// </summary>
        /// <param name="name">name the name of the new resource</param>
        /// <returns>the first stage of the new resource definition</returns>
        Microsoft.Azure.Management.Compute.Fluent.VirtualMachineScaleSet.Definition.IBlank Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions.ISupportsCreating<Microsoft.Azure.Management.Compute.Fluent.VirtualMachineScaleSet.Definition.IBlank>.Define(string name) { 
            return this.Define( name) as Microsoft.Azure.Management.Compute.Fluent.VirtualMachineScaleSet.Definition.IBlank;
        }

        /// <summary>
        /// Lists resources of the specified type in the specified resource group.
        /// </summary>
        /// <param name="resourceGroupName">resourceGroupName the name of the resource group to list the resources from</param>
        /// <returns>the list of resources</returns>
        Microsoft.Azure.Management.Resource.Fluent.Core.PagedList<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSet> Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions.ISupportsListingByGroup<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSet>.ListByGroup(string resourceGroupName) { 
            return this.ListByGroup( resourceGroupName) as Microsoft.Azure.Management.Resource.Fluent.Core.PagedList<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSet>;
        }

        /// <summary>
        /// Gets the information about a resource from Azure based on the resource name and the name of its resource group.
        /// </summary>
        /// <param name="resourceGroupName">resourceGroupName the name of the resource group the resource is in</param>
        /// <param name="name">name the name of the resource. (Note, this is not the ID)</param>
        /// <returns>an immutable representation of the resource</returns>
        Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSet Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions.ISupportsGettingByGroup<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSet>.GetByGroup(string resourceGroupName, string name) { 
            return this.GetByGroup( resourceGroupName,  name) as Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSet;
        }

        /// <summary>
        /// Re-images (updates the version of the installed operating system) the virtual machines in the scale set.
        /// </summary>
        /// <param name="groupName">groupName the name of the resource group the virtual machine scale set is in</param>
        /// <param name="name">name the name of the virtual machine scale set</param>
        void Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSets.Reimage(string groupName, string name) { 
            this.Reimage( groupName,  name);
        }

        /// <summary>
        /// Starts the virtual machines in the scale set.
        /// </summary>
        /// <param name="groupName">groupName the name of the resource group the virtual machine scale set is in</param>
        /// <param name="name">name the name of the virtual machine scale set</param>
        void Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSets.Start(string groupName, string name) { 
            this.Start( groupName,  name);
        }

        /// <summary>
        /// Powers off (stops) the virtual machines in the scale set.
        /// </summary>
        /// <param name="groupName">groupName the name of the resource group the virtual machine scale set is in</param>
        /// <param name="name">name the name of the virtual machine scale set</param>
        void Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSets.PowerOff(string groupName, string name) { 
            this.PowerOff( groupName,  name);
        }

        /// <summary>
        /// Shuts down the virtual machine in the scale set and releases the compute resources.
        /// </summary>
        /// <param name="groupName">groupName the name of the resource group the virtual machine scale set is in</param>
        /// <param name="name">name the name of the virtual machine scale set</param>
        void Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSets.Deallocate(string groupName, string name) { 
            this.Deallocate( groupName,  name);
        }

        /// <summary>
        /// Restarts the virtual machines in the scale set.
        /// </summary>
        /// <param name="groupName">groupName the name of the resource group the virtual machine scale set is in</param>
        /// <param name="name">name the name of the virtual machine scale set</param>
        void Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSets.Restart(string groupName, string name) { 
            this.Restart( groupName,  name);
        }

        /// <summary>
        /// Asynchronously delete a resource from Azure, identifying it by its name and its resource group.
        /// </summary>
        /// <param name="groupName">groupName The group the resource is part of</param>
        /// <param name="name">name The name of the resource</param>
        /// <param name="cancellationToken">cancellationToken the cancellation token</param>
        /// <returns>an observable to the request</returns>
        Task Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions.ISupportsDeletingByGroup.DeleteByGroupAsync(string groupName, string name, CancellationToken cancellationToken = default(CancellationToken)) { 
            return this.DeleteByGroupAsync( groupName,  name, cancellationToken);
        }

        /// <summary>
        /// Lists all the resources of the specified type in the currently selected subscription.
        /// </summary>
        /// <returns>list of resources</returns>
        Microsoft.Azure.Management.Resource.Fluent.Core.PagedList<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSet> Microsoft.Azure.Management.Resource.Fluent.Core.CollectionActions.ISupportsListing<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSet>.List() { 
            return this.List() as Microsoft.Azure.Management.Resource.Fluent.Core.PagedList<Microsoft.Azure.Management.Compute.Fluent.IVirtualMachineScaleSet>;
        }

    }
}