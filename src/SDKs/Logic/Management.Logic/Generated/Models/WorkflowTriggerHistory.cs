// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Microsoft.Azure.Management.Logic.Models
{
    using Azure;
    using Management;
    using Logic;
    using Rest;
    using Rest.Serialization;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The workflow trigger history.
    /// </summary>
    [JsonTransformation]
    public partial class WorkflowTriggerHistory : SubResource
    {
        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerHistory class.
        /// </summary>
        public WorkflowTriggerHistory() { }

        /// <summary>
        /// Initializes a new instance of the WorkflowTriggerHistory class.
        /// </summary>
        /// <param name="id">The resource id.</param>
        /// <param name="startTime">Gets the start time.</param>
        /// <param name="endTime">Gets the end time.</param>
        /// <param name="status">Gets the status. Possible values include:
        /// 'NotSpecified', 'Paused', 'Running', 'Waiting', 'Succeeded',
        /// 'Skipped', 'Suspended', 'Cancelled', 'Failed', 'Faulted',
        /// 'TimedOut', 'Aborted', 'Ignored'</param>
        /// <param name="code">Gets the code.</param>
        /// <param name="error">Gets the error.</param>
        /// <param name="trackingId">Gets the tracking id.</param>
        /// <param name="correlation">The run correlation.</param>
        /// <param name="inputsLink">Gets the link to input parameters.</param>
        /// <param name="outputsLink">Gets the link to output
        /// parameters.</param>
        /// <param name="fired">Gets a value indicating whether trigger was
        /// fired.</param>
        /// <param name="run">Gets the reference to workflow run.</param>
        /// <param name="name">Gets the workflow trigger history name.</param>
        /// <param name="type">Gets the workflow trigger history type.</param>
        public WorkflowTriggerHistory(string id = default(string), System.DateTime? startTime = default(System.DateTime?), System.DateTime? endTime = default(System.DateTime?), WorkflowStatus? status = default(WorkflowStatus?), string code = default(string), object error = default(object), string trackingId = default(string), Correlation correlation = default(Correlation), ContentLink inputsLink = default(ContentLink), ContentLink outputsLink = default(ContentLink), bool? fired = default(bool?), ResourceReference run = default(ResourceReference), string name = default(string), string type = default(string))
            : base(id)
        {
            StartTime = startTime;
            EndTime = endTime;
            Status = status;
            Code = code;
            Error = error;
            TrackingId = trackingId;
            Correlation = correlation;
            InputsLink = inputsLink;
            OutputsLink = outputsLink;
            Fired = fired;
            Run = run;
            Name = name;
            Type = type;
        }

        /// <summary>
        /// Gets the start time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.startTime")]
        public System.DateTime? StartTime { get; protected set; }

        /// <summary>
        /// Gets the end time.
        /// </summary>
        [JsonProperty(PropertyName = "properties.endTime")]
        public System.DateTime? EndTime { get; protected set; }

        /// <summary>
        /// Gets the status. Possible values include: 'NotSpecified', 'Paused',
        /// 'Running', 'Waiting', 'Succeeded', 'Skipped', 'Suspended',
        /// 'Cancelled', 'Failed', 'Faulted', 'TimedOut', 'Aborted', 'Ignored'
        /// </summary>
        [JsonProperty(PropertyName = "properties.status")]
        public WorkflowStatus? Status { get; protected set; }

        /// <summary>
        /// Gets the code.
        /// </summary>
        [JsonProperty(PropertyName = "properties.code")]
        public string Code { get; protected set; }

        /// <summary>
        /// Gets the error.
        /// </summary>
        [JsonProperty(PropertyName = "properties.error")]
        public object Error { get; protected set; }

        /// <summary>
        /// Gets the tracking id.
        /// </summary>
        [JsonProperty(PropertyName = "properties.trackingId")]
        public string TrackingId { get; protected set; }

        /// <summary>
        /// Gets or sets the run correlation.
        /// </summary>
        [JsonProperty(PropertyName = "properties.correlation")]
        public Correlation Correlation { get; set; }

        /// <summary>
        /// Gets the link to input parameters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.inputsLink")]
        public ContentLink InputsLink { get; protected set; }

        /// <summary>
        /// Gets the link to output parameters.
        /// </summary>
        [JsonProperty(PropertyName = "properties.outputsLink")]
        public ContentLink OutputsLink { get; protected set; }

        /// <summary>
        /// Gets a value indicating whether trigger was fired.
        /// </summary>
        [JsonProperty(PropertyName = "properties.fired")]
        public bool? Fired { get; protected set; }

        /// <summary>
        /// Gets the reference to workflow run.
        /// </summary>
        [JsonProperty(PropertyName = "properties.run")]
        public ResourceReference Run { get; protected set; }

        /// <summary>
        /// Gets the workflow trigger history name.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; protected set; }

        /// <summary>
        /// Gets the workflow trigger history type.
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; protected set; }

    }
}

