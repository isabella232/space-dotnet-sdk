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
public abstract class ChatChannel : IUrlParameter
{
    public static ChatChannel FromId(string id)
        => new ChatChannelFromId(id);
    
    public static ChatChannel FromName(string name)
        => new ChatChannelFromName(name);
    
    public class ChatChannelFromId : ChatChannel
    {
        private readonly string _id;
        
        public ChatChannelFromId(string id)
        {
            _id = id;
        }
        
        public override string ToString()
            => $"id:{_id}";
    }
    
    public class ChatChannelFromName : ChatChannel
    {
        private readonly string _name;
        
        public ChatChannelFromName(string name)
        {
            _name = name;
        }
        
        public override string ToString()
            => $"name:{_name}";
    }
    
}

