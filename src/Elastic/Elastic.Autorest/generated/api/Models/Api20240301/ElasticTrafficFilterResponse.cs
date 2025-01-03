// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20240301
{
    using static Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Extensions;

    /// <summary>List of elastic traffic filters in the account</summary>
    public partial class ElasticTrafficFilterResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20240301.IElasticTrafficFilterResponse,
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20240301.IElasticTrafficFilterResponseInternal
    {

        /// <summary>Backing field for <see cref="Ruleset" /> property.</summary>
        private Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20240301.IElasticTrafficFilter[] _ruleset;

        /// <summary>List of elastic traffic filters in the account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Origin(Microsoft.Azure.PowerShell.Cmdlets.Elastic.PropertyOrigin.Owned)]
        public Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20240301.IElasticTrafficFilter[] Ruleset { get => this._ruleset; set => this._ruleset = value; }

        /// <summary>Creates an new <see cref="ElasticTrafficFilterResponse" /> instance.</summary>
        public ElasticTrafficFilterResponse()
        {

        }
    }
    /// List of elastic traffic filters in the account
    public partial interface IElasticTrafficFilterResponse :
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.IJsonSerializable
    {
        /// <summary>List of elastic traffic filters in the account</summary>
        [Microsoft.Azure.PowerShell.Cmdlets.Elastic.Runtime.Info(
        Required = false,
        ReadOnly = false,
        Description = @"List of elastic traffic filters in the account",
        SerializedName = @"rulesets",
        PossibleTypes = new [] { typeof(Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20240301.IElasticTrafficFilter) })]
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20240301.IElasticTrafficFilter[] Ruleset { get; set; }

    }
    /// List of elastic traffic filters in the account
    internal partial interface IElasticTrafficFilterResponseInternal

    {
        /// <summary>List of elastic traffic filters in the account</summary>
        Microsoft.Azure.PowerShell.Cmdlets.Elastic.Models.Api20240301.IElasticTrafficFilter[] Ruleset { get; set; }

    }
}