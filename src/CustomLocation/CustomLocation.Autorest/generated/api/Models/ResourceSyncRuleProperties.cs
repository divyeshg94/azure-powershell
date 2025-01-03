// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models
{
    using static Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Extensions;

    /// <summary>
    /// Properties for a resource sync rule. For an unmapped custom resource, its labels will be used to find out matching resource
    /// sync rules using the selector property of the resource sync rule. If this resource sync rule has highest priority among
    /// all matching rules, then the unmapped custom resource will be projected to the target resource group associated with this
    /// resource sync rule.
    /// </summary>
    public partial class ResourceSyncRuleProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRuleProperties,
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesInternal
    {

        /// <summary>Internal Acessors for ProvisioningState</summary>
        string Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesInternal.ProvisioningState { get => this._provisioningState; set { {_provisioningState = value;} } }

        /// <summary>Internal Acessors for Selector</summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesSelector Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesInternal.Selector { get => (this._selector = this._selector ?? new Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.ResourceSyncRulePropertiesSelector()); set { {_selector = value;} } }

        /// <summary>Backing field for <see cref="Priority" /> property.</summary>
        private int? _priority;

        /// <summary>Priority represents a priority of the Resource Sync Rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Owned)]
        public int? Priority { get => this._priority; set => this._priority = value; }

        /// <summary>Backing field for <see cref="ProvisioningState" /> property.</summary>
        private string _provisioningState;

        /// <summary>Provisioning State for the Resource Sync Rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Owned)]
        public string ProvisioningState { get => this._provisioningState; }

        /// <summary>Backing field for <see cref="Selector" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesSelector _selector;

        /// <summary>
        /// A label selector is composed of two parts, matchLabels and matchExpressions. The first part, matchLabels is a map of {key,value}
        /// pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is
        /// 'key', the operator is 'In', and the values array contains only 'value'. The second part, matchExpressions is a list of
        /// resource selector requirements. Valid operators include In, NotIn, Exists, and DoesNotExist. The values set must be non-empty
        /// in the case of In and NotIn. The values set must be empty in the case of Exists and DoesNotExist. All of the requirements,
        /// from both matchLabels and matchExpressions must all be satisfied in order to match.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Owned)]
        internal Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesSelector Selector { get => (this._selector = this._selector ?? new Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.ResourceSyncRulePropertiesSelector()); set => this._selector = value; }

        /// <summary>
        /// MatchExpressions is a list of resource selector requirements. Valid operators include In, NotIn, Exists, and DoesNotExist.
        /// The values set must be non-empty in the case of In and NotIn. The values set must be empty in the case of Exists and DoesNotExist.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        public System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IMatchExpressionsProperties> SelectorMatchExpression { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesSelectorInternal)Selector).MatchExpression; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesSelectorInternal)Selector).MatchExpression = value ?? null /* arrayOf */; }

        /// <summary>
        /// MatchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of
        /// matchExpressions, whose key field is 'key', the operator is 'In', and the values array contains only 'value'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Inlined)]
        public Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesSelectorMatchLabels SelectorMatchLabel { get => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesSelectorInternal)Selector).MatchLabel; set => ((Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesSelectorInternal)Selector).MatchLabel = value ?? null /* model class */; }

        /// <summary>Backing field for <see cref="TargetResourceGroup" /> property.</summary>
        private string _targetResourceGroup;

        /// <summary>
        /// For an unmapped custom resource, its labels will be used to find matching resource sync rules. If this resource sync rule
        /// is one of the matching rules with highest priority, then the unmapped custom resource will be projected to the target
        /// resource group associated with this resource sync rule. The user creating this resource sync rule should have write permissions
        /// on the target resource group and this write permission will be validated when creating the resource sync rule.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Origin(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.PropertyOrigin.Owned)]
        public string TargetResourceGroup { get => this._targetResourceGroup; set => this._targetResourceGroup = value; }

        /// <summary>Creates an new <see cref="ResourceSyncRuleProperties" /> instance.</summary>
        public ResourceSyncRuleProperties()
        {

        }
    }
    /// Properties for a resource sync rule. For an unmapped custom resource, its labels will be used to find out matching resource
    /// sync rules using the selector property of the resource sync rule. If this resource sync rule has highest priority among
    /// all matching rules, then the unmapped custom resource will be projected to the target resource group associated with this
    /// resource sync rule.
    public partial interface IResourceSyncRuleProperties :
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.IJsonSerializable
    {
        /// <summary>Priority represents a priority of the Resource Sync Rule</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"Priority represents a priority of the Resource Sync Rule",
        SerializedName = @"priority",
        PossibleTypes = new [] { typeof(int) })]
        int? Priority { get; set; }
        /// <summary>Provisioning State for the Resource Sync Rule.</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = true,
        Read = true,
        Create = false,
        Update = false,
        Description = @"Provisioning State for the Resource Sync Rule.",
        SerializedName = @"provisioningState",
        PossibleTypes = new [] { typeof(string) })]
        string ProvisioningState { get;  }
        /// <summary>
        /// MatchExpressions is a list of resource selector requirements. Valid operators include In, NotIn, Exists, and DoesNotExist.
        /// The values set must be non-empty in the case of In and NotIn. The values set must be empty in the case of Exists and DoesNotExist.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"MatchExpressions is a list of resource selector requirements. Valid operators include In, NotIn, Exists, and DoesNotExist. The values set must be non-empty in the case of In and NotIn. The values set must be empty in the case of Exists and DoesNotExist.",
        SerializedName = @"matchExpressions",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IMatchExpressionsProperties) })]
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IMatchExpressionsProperties> SelectorMatchExpression { get; set; }
        /// <summary>
        /// MatchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of
        /// matchExpressions, whose key field is 'key', the operator is 'In', and the values array contains only 'value'.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"MatchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is 'key', the operator is 'In', and the values array contains only 'value'.",
        SerializedName = @"matchLabels",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesSelectorMatchLabels) })]
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesSelectorMatchLabels SelectorMatchLabel { get; set; }
        /// <summary>
        /// For an unmapped custom resource, its labels will be used to find matching resource sync rules. If this resource sync rule
        /// is one of the matching rules with highest priority, then the unmapped custom resource will be projected to the target
        /// resource group associated with this resource sync rule. The user creating this resource sync rule should have write permissions
        /// on the target resource group and this write permission will be validated when creating the resource sync rule.
        /// </summary>
        [Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Read = true,
        Create = true,
        Update = true,
        Description = @"For an unmapped custom resource, its labels will be used to find matching resource sync rules. If this resource sync rule is one of the matching rules with highest priority, then the unmapped custom resource will be projected to the target resource group associated with this resource sync rule. The user creating this resource sync rule should have write permissions on the target resource group and this write permission will be validated when creating the resource sync rule.",
        SerializedName = @"targetResourceGroup",
        PossibleTypes = new [] { typeof(string) })]
        string TargetResourceGroup { get; set; }

    }
    /// Properties for a resource sync rule. For an unmapped custom resource, its labels will be used to find out matching resource
    /// sync rules using the selector property of the resource sync rule. If this resource sync rule has highest priority among
    /// all matching rules, then the unmapped custom resource will be projected to the target resource group associated with this
    /// resource sync rule.
    internal partial interface IResourceSyncRulePropertiesInternal

    {
        /// <summary>Priority represents a priority of the Resource Sync Rule</summary>
        int? Priority { get; set; }
        /// <summary>Provisioning State for the Resource Sync Rule.</summary>
        string ProvisioningState { get; set; }
        /// <summary>
        /// A label selector is composed of two parts, matchLabels and matchExpressions. The first part, matchLabels is a map of {key,value}
        /// pairs. A single {key,value} in the matchLabels map is equivalent to an element of matchExpressions, whose key field is
        /// 'key', the operator is 'In', and the values array contains only 'value'. The second part, matchExpressions is a list of
        /// resource selector requirements. Valid operators include In, NotIn, Exists, and DoesNotExist. The values set must be non-empty
        /// in the case of In and NotIn. The values set must be empty in the case of Exists and DoesNotExist. All of the requirements,
        /// from both matchLabels and matchExpressions must all be satisfied in order to match.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesSelector Selector { get; set; }
        /// <summary>
        /// MatchExpressions is a list of resource selector requirements. Valid operators include In, NotIn, Exists, and DoesNotExist.
        /// The values set must be non-empty in the case of In and NotIn. The values set must be empty in the case of Exists and DoesNotExist.
        /// </summary>
        System.Collections.Generic.List<Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IMatchExpressionsProperties> SelectorMatchExpression { get; set; }
        /// <summary>
        /// MatchLabels is a map of {key,value} pairs. A single {key,value} in the matchLabels map is equivalent to an element of
        /// matchExpressions, whose key field is 'key', the operator is 'In', and the values array contains only 'value'.
        /// </summary>
        Microsoft.Azure.PowerShell.Cmdlets.CustomLocation.Models.IResourceSyncRulePropertiesSelectorMatchLabels SelectorMatchLabel { get; set; }
        /// <summary>
        /// For an unmapped custom resource, its labels will be used to find matching resource sync rules. If this resource sync rule
        /// is one of the matching rules with highest priority, then the unmapped custom resource will be projected to the target
        /// resource group associated with this resource sync rule. The user creating this resource sync rule should have write permissions
        /// on the target resource group and this write permission will be validated when creating the resource sync rule.
        /// </summary>
        string TargetResourceGroup { get; set; }

    }
}