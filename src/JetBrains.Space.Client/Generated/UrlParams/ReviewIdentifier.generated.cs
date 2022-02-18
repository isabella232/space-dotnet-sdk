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
public abstract class ReviewIdentifier : IUrlParameter
{
    public static ReviewIdentifier Id(string id)
        => new ReviewIdentifierId(id);
    
    public static ReviewIdentifier Key(string key)
        => new ReviewIdentifierKey(key);
    
    public static ReviewIdentifier Number(int number)
        => new ReviewIdentifierNumber(number);
    
    public class ReviewIdentifierId : ReviewIdentifier
    {
        public string Id { get; }
        
        public ReviewIdentifierId(string id)
        {
            Id = id;
        }
        
        public override string ToString()
            => $"id:{Id}";
    }
    
    public class ReviewIdentifierKey : ReviewIdentifier
    {
        public string Key { get; }
        
        public ReviewIdentifierKey(string key)
        {
            Key = key;
        }
        
        public override string ToString()
            => $"key:{Key}";
    }
    
    public class ReviewIdentifierNumber : ReviewIdentifier
    {
        public int Number { get; }
        
        public ReviewIdentifierNumber(int number)
        {
            Number = number;
        }
        
        public override string ToString()
            => $"number:{Number}";
    }
    
}

