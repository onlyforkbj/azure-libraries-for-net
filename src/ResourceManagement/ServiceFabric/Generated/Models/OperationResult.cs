// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.ServiceFabric.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.ServiceFabric;
    using Microsoft.Azure.Management.ServiceFabric.Fluent;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// Available operation list result
    /// </summary>
    public partial class OperationResult
    {
        /// <summary>
        /// Initializes a new instance of the OperationResult class.
        /// </summary>
        public OperationResult()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the OperationResult class.
        /// </summary>
        /// <param name="name">Result name</param>
        /// <param name="display">Dispaly of the result</param>
        /// <param name="origin">Origin result</param>
        /// <param name="nextLink">The URL to use for getting the next set of
        /// results.</param>
        public OperationResult(string name = default(string), AvailableOperationDisplay display = default(AvailableOperationDisplay), string origin = default(string), string nextLink = default(string))
        {
            Name = name;
            Display = display;
            Origin = origin;
            NextLink = nextLink;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets result name
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets dispaly of the result
        /// </summary>
        [JsonProperty(PropertyName = "display")]
        public AvailableOperationDisplay Display { get; set; }

        /// <summary>
        /// Gets or sets origin result
        /// </summary>
        [JsonProperty(PropertyName = "origin")]
        public string Origin { get; set; }

        /// <summary>
        /// Gets or sets the URL to use for getting the next set of results.
        /// </summary>
        [JsonProperty(PropertyName = "nextLink")]
        public string NextLink { get; set; }

    }
}
