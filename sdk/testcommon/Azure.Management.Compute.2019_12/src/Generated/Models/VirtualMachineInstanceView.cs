// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System.Collections.Generic;
using Azure.Core;

namespace Azure.Management.Compute.Models
{
    /// <summary> The instance view of a virtual machine. </summary>
    public partial class VirtualMachineInstanceView
    {
        /// <summary> Initializes a new instance of VirtualMachineInstanceView. </summary>
        internal VirtualMachineInstanceView()
        {
            Disks = new ChangeTrackingList<DiskInstanceView>();
            Extensions = new ChangeTrackingList<VirtualMachineExtensionInstanceView>();
            Statuses = new ChangeTrackingList<InstanceViewStatus>();
        }

        /// <summary> Initializes a new instance of VirtualMachineInstanceView. </summary>
        /// <param name="platformUpdateDomain"> Specifies the update domain of the virtual machine. </param>
        /// <param name="platformFaultDomain"> Specifies the fault domain of the virtual machine. </param>
        /// <param name="computerName"> The computer name assigned to the virtual machine. </param>
        /// <param name="osName"> The Operating System running on the virtual machine. </param>
        /// <param name="osVersion"> The version of Operating System running on the virtual machine. </param>
        /// <param name="hyperVGeneration"> Specifies the HyperVGeneration Type associated with a resource. </param>
        /// <param name="rdpThumbPrint"> The Remote desktop certificate thumbprint. </param>
        /// <param name="vmAgent"> The VM Agent running on the virtual machine. </param>
        /// <param name="maintenanceRedeployStatus"> The Maintenance Operation status on the virtual machine. </param>
        /// <param name="disks"> The virtual machine disk information. </param>
        /// <param name="extensions"> The extensions information. </param>
        /// <param name="bootDiagnostics"> Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. &lt;br&gt;&lt;br&gt; You can easily view the output of your console log. &lt;br&gt;&lt;br&gt; Azure also enables you to see a screenshot of the VM from the hypervisor. </param>
        /// <param name="statuses"> The resource status information. </param>
        internal VirtualMachineInstanceView(int? platformUpdateDomain, int? platformFaultDomain, string computerName, string osName, string osVersion, HyperVGenerationType? hyperVGeneration, string rdpThumbPrint, VirtualMachineAgentInstanceView vmAgent, MaintenanceRedeployStatus maintenanceRedeployStatus, IReadOnlyList<DiskInstanceView> disks, IReadOnlyList<VirtualMachineExtensionInstanceView> extensions, BootDiagnosticsInstanceView bootDiagnostics, IReadOnlyList<InstanceViewStatus> statuses)
        {
            PlatformUpdateDomain = platformUpdateDomain;
            PlatformFaultDomain = platformFaultDomain;
            ComputerName = computerName;
            OsName = osName;
            OsVersion = osVersion;
            HyperVGeneration = hyperVGeneration;
            RdpThumbPrint = rdpThumbPrint;
            VmAgent = vmAgent;
            MaintenanceRedeployStatus = maintenanceRedeployStatus;
            Disks = disks;
            Extensions = extensions;
            BootDiagnostics = bootDiagnostics;
            Statuses = statuses;
        }

        /// <summary> Specifies the update domain of the virtual machine. </summary>
        public int? PlatformUpdateDomain { get; }
        /// <summary> Specifies the fault domain of the virtual machine. </summary>
        public int? PlatformFaultDomain { get; }
        /// <summary> The computer name assigned to the virtual machine. </summary>
        public string ComputerName { get; }
        /// <summary> The Operating System running on the virtual machine. </summary>
        public string OsName { get; }
        /// <summary> The version of Operating System running on the virtual machine. </summary>
        public string OsVersion { get; }
        /// <summary> Specifies the HyperVGeneration Type associated with a resource. </summary>
        public HyperVGenerationType? HyperVGeneration { get; }
        /// <summary> The Remote desktop certificate thumbprint. </summary>
        public string RdpThumbPrint { get; }
        /// <summary> The VM Agent running on the virtual machine. </summary>
        public VirtualMachineAgentInstanceView VmAgent { get; }
        /// <summary> The Maintenance Operation status on the virtual machine. </summary>
        public MaintenanceRedeployStatus MaintenanceRedeployStatus { get; }
        /// <summary> The virtual machine disk information. </summary>
        public IReadOnlyList<DiskInstanceView> Disks { get; }
        /// <summary> The extensions information. </summary>
        public IReadOnlyList<VirtualMachineExtensionInstanceView> Extensions { get; }
        /// <summary> Boot Diagnostics is a debugging feature which allows you to view Console Output and Screenshot to diagnose VM status. &lt;br&gt;&lt;br&gt; You can easily view the output of your console log. &lt;br&gt;&lt;br&gt; Azure also enables you to see a screenshot of the VM from the hypervisor. </summary>
        public BootDiagnosticsInstanceView BootDiagnostics { get; }
        /// <summary> The resource status information. </summary>
        public IReadOnlyList<InstanceViewStatus> Statuses { get; }
    }
}
