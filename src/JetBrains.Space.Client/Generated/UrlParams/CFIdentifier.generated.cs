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
public abstract class CFIdentifier : IUrlParameter
{
    public static CFIdentifier Id(string id)
        => new CFIdentifierId(id);
    
    public static CFIdentifier Name(string name)
        => new CFIdentifierName(name);
    
    public class CFIdentifierId : CFIdentifier
    {
        [Required]
        [JsonPropertyName("id")]
#if NET6_0_OR_GREATER
        public string Id { get; init; }
#else
        public string Id { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public CFIdentifierId() { }
#endif
        
        public CFIdentifierId(string id)
        {
            Id = id;
        }
        
        public override string ToString()
            => $"id:{Id}";
    }
    
    public class CFIdentifierName : CFIdentifier
    {
        [Required]
        [JsonPropertyName("name")]
#if NET6_0_OR_GREATER
        public string Name { get; init; }
#else
        public string Name { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public CFIdentifierName() { }
#endif
        
        public CFIdentifierName(string name)
        {
            Name = name;
        }
        
        public override string ToString()
            => $"name:{Name}";
    }
    
}

