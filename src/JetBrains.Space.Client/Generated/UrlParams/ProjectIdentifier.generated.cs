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

namespace JetBrains.Space.Client
{
    [JsonConverter(typeof(UrlParameterConverter))]
    public abstract class ProjectIdentifier : IUrlParameter
    {
        public static ProjectIdentifier Id(string id)
            => new ProjectIdentifierId(id);
        
        public static ProjectIdentifier Key(string key)
            => new ProjectIdentifierKey(key);
        
        private class ProjectIdentifierId : ProjectIdentifier
        {
            private readonly string _id;
            
            public ProjectIdentifierId(string id)
            {
                _id = id;
            }
            
            public override string ToString()
                => $"id:{_id}";
        }
        
        private class ProjectIdentifierKey : ProjectIdentifier
        {
            private readonly string _key;
            
            public ProjectIdentifierKey(string key)
            {
                _key = key;
            }
            
            public override string ToString()
                => $"key:{_key}";
        }
        
    }
    
}
