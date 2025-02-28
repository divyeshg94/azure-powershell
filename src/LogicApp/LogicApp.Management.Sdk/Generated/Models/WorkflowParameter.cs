// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using System.Linq;

    /// <summary>
    /// The workflow parameters.
    /// </summary>
    public partial class WorkflowParameter
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowParameter class.
        /// </summary>
        public WorkflowParameter()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the WorkflowParameter class.
        /// </summary>

        /// <param name="type">The type.
        /// Possible values include: &#39;NotSpecified&#39;, &#39;String&#39;, &#39;SecureString&#39;, &#39;Int&#39;,
        /// &#39;Float&#39;, &#39;Bool&#39;, &#39;Array&#39;, &#39;Object&#39;, &#39;SecureObject&#39;</param>

        /// <param name="value">The value.
        /// </param>

        /// <param name="metadata">The metadata.
        /// </param>

        /// <param name="description">The description.
        /// </param>
        public WorkflowParameter(string type = default(string), object value = default(object), object metadata = default(object), string description = default(string))

        {
            this.Type = type;
            this.Value = value;
            this.Metadata = metadata;
            this.Description = description;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();


        /// <summary>
        /// Gets or sets the type. Possible values include: &#39;NotSpecified&#39;, &#39;String&#39;, &#39;SecureString&#39;, &#39;Int&#39;, &#39;Float&#39;, &#39;Bool&#39;, &#39;Array&#39;, &#39;Object&#39;, &#39;SecureObject&#39;
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "type")]
        public string Type {get; set; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "value")]
        public object Value {get; set; }

        /// <summary>
        /// Gets or sets the metadata.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "metadata")]
        public object Metadata {get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "description")]
        public string Description {get; set; }
    }
}