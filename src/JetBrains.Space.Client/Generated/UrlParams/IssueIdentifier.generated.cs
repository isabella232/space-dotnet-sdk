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
public abstract class IssueIdentifier : IUrlParameter
{
    public static IssueIdentifier Id(string id)
        => new IssueIdentifierId(id);
    
    public static IssueIdentifier Key(string key)
        => new IssueIdentifierKey(key);
    
    public class IssueIdentifierId : IssueIdentifier
    {
        private readonly string _id;
        
        public IssueIdentifierId(string id)
        {
            _id = id;
        }
        
        public override string ToString()
            => $"id:{_id}";
    }
    
    public class IssueIdentifierKey : IssueIdentifier
    {
        private readonly string _key;
        
        public IssueIdentifierKey(string key)
        {
            _key = key;
        }
        
        public override string ToString()
            => $"key:{_key}";
    }
    
}

