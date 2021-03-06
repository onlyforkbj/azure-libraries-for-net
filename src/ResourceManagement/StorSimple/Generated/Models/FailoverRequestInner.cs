// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// </auto-generated>

namespace Microsoft.Azure.Management.StorSimple.Fluent.Models
{
    using Microsoft.Azure;
    using Microsoft.Azure.Management;
    using Microsoft.Azure.Management.StorSimple;
    using Microsoft.Azure.Management.StorSimple.Fluent;
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// The request object for triggering a failover of volume containers, from
    /// a source device to a target device.
    /// </summary>
    public partial class FailoverRequestInner
    {
        /// <summary>
        /// Initializes a new instance of the FailoverRequestInner class.
        /// </summary>
        public FailoverRequestInner()
        {
          CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the FailoverRequestInner class.
        /// </summary>
        /// <param name="targetDeviceId">The ARM path ID of the device which
        /// will act as the failover target.</param>
        /// <param name="volumeContainers">The list of path IDs of the volume
        /// containers which needs to be failed-over to the target
        /// device.</param>
        public FailoverRequestInner(string targetDeviceId = default(string), IList<string> volumeContainers = default(IList<string>))
        {
            TargetDeviceId = targetDeviceId;
            VolumeContainers = volumeContainers;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets or sets the ARM path ID of the device which will act as the
        /// failover target.
        /// </summary>
        [JsonProperty(PropertyName = "targetDeviceId")]
        public string TargetDeviceId { get; set; }

        /// <summary>
        /// Gets or sets the list of path IDs of the volume containers which
        /// needs to be failed-over to the target device.
        /// </summary>
        [JsonProperty(PropertyName = "volumeContainers")]
        public IList<string> VolumeContainers { get; set; }

    }
}
