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
public abstract class ProfileIdentifier : IUrlParameter
{
    public static ProfileIdentifier ExternalId(string externalId)
        => new ProfileIdentifierExternalId(externalId);
    
    public static ProfileIdentifier Id(string id)
        => new ProfileIdentifierId(id);
    
    public static ProfileIdentifier Me
        => new ProfileIdentifierMe();
    
    public static ProfileIdentifier Username(string username)
        => new ProfileIdentifierUsername(username);
    
    public class ProfileIdentifierExternalId : ProfileIdentifier
    {
        [Required]
        [JsonPropertyName("externalId")]
#if NET6_0_OR_GREATER
        public string ExternalId { get; init; }
#else
        public string ExternalId { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public ProfileIdentifierExternalId() { }
#endif
        
        public ProfileIdentifierExternalId(string externalId)
        {
            ExternalId = externalId;
        }
        
        public override string ToString()
            => $"externalId:{ExternalId}";
    }
    
    public class ProfileIdentifierId : ProfileIdentifier
    {
        [Required]
        [JsonPropertyName("id")]
#if NET6_0_OR_GREATER
        public string Id { get; init; }
#else
        public string Id { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public ProfileIdentifierId() { }
#endif
        
        public ProfileIdentifierId(string id)
        {
            Id = id;
        }
        
        public override string ToString()
            => $"id:{Id}";
    }
    
    public class ProfileIdentifierMe : ProfileIdentifier
    {
        public override string ToString()
            => "me";
    }
    
    public class ProfileIdentifierUsername : ProfileIdentifier
    {
        [Required]
        [JsonPropertyName("username")]
#if NET6_0_OR_GREATER
        public string Username { get; init; }
#else
        public string Username { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public ProfileIdentifierUsername() { }
#endif
        
        public ProfileIdentifierUsername(string username)
        {
            Username = username;
        }
        
        public override string ToString()
            => $"username:{Username}";
    }
    
}

