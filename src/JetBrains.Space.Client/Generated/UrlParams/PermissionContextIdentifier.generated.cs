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
public abstract class PermissionContextIdentifier : IUrlParameter
{
    public static PermissionContextIdentifier Channel(string channel)
        => new ChannelPermissionContextIdentifier(channel);
    
    public static PermissionContextIdentifier Global
        => new GlobalPermissionContextIdentifier();
    
    public static PermissionContextIdentifier Project(ProjectIdentifier project)
        => new ProjectPermissionContextIdentifier(project);
    
    public class ChannelPermissionContextIdentifier : PermissionContextIdentifier
    {
        private readonly string _channel;
        
        public ChannelPermissionContextIdentifier(string channel)
        {
            _channel = channel;
        }
        
        public override string ToString()
            => $"channel:{_channel}";
    }
    
    public class GlobalPermissionContextIdentifier : PermissionContextIdentifier
    {
        public override string ToString()
            => "global";
    }
    
    public class ProjectPermissionContextIdentifier : PermissionContextIdentifier
    {
        private readonly ProjectIdentifier _project;
        
        public ProjectPermissionContextIdentifier(ProjectIdentifier project)
        {
            _project = project;
        }
        
        public override string ToString()
            => $"project:{_project}";
    }
    
}

