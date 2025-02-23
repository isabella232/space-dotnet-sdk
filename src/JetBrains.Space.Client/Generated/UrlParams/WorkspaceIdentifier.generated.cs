// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS1591
#pragma warning disable CS0108
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

[JsonConverter(typeof(UrlParameterConverter))]
public abstract class WorkspaceIdentifier : IUrlParameter
{
    public static WorkspaceIdentifier ByProject(ProjectIdentifier project, int number)
        => new WorkspaceIdentifierByProject(project, number);
    
    public static WorkspaceIdentifier ExternalId(string externalId)
        => new WorkspaceIdentifierExternalId(externalId);
    
    public static WorkspaceIdentifier Id(string id)
        => new WorkspaceIdentifierId(id);
    
    public class WorkspaceIdentifierByProject : WorkspaceIdentifier
    {
        [Required]
        [JsonPropertyName("project")]
#if NET6_0_OR_GREATER
        public ProjectIdentifier Project { get; init; }
#else
        public ProjectIdentifier Project { get; set; }
#endif
        
        [Required]
        [JsonPropertyName("number")]
#if NET6_0_OR_GREATER
        public int Number { get; init; }
#else
        public int Number { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public WorkspaceIdentifierByProject() { }
#endif
        
        public WorkspaceIdentifierByProject(ProjectIdentifier project, int number)
        {
            Project = project;
            Number = number;
        }
        
        public override string ToString()
            => $"{{project:{Project},number:{Number}}}";
    }
    
    public class WorkspaceIdentifierExternalId : WorkspaceIdentifier
    {
        [Required]
        [JsonPropertyName("externalId")]
#if NET6_0_OR_GREATER
        public string ExternalId { get; init; }
#else
        public string ExternalId { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public WorkspaceIdentifierExternalId() { }
#endif
        
        public WorkspaceIdentifierExternalId(string externalId)
        {
            ExternalId = externalId;
        }
        
        public override string ToString()
            => $"externalId:{ExternalId}";
    }
    
    public class WorkspaceIdentifierId : WorkspaceIdentifier
    {
        [Required]
        [JsonPropertyName("id")]
#if NET6_0_OR_GREATER
        public string Id { get; init; }
#else
        public string Id { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public WorkspaceIdentifierId() { }
#endif
        
        public WorkspaceIdentifierId(string id)
        {
            Id = id;
        }
        
        public override string ToString()
            => $"id:{Id}";
    }
    
}

