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

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public sealed class NpmPackageDependency
         : IPropagatePropertyAccessPath
    {
        public NpmPackageDependency() { }
        
        public NpmPackageDependency(string name, string version, string? type = null)
        {
            Name = name;
            Version = version;
            Type = type;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(NpmPackageDependency), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _version = new PropertyValue<string>(nameof(NpmPackageDependency), nameof(Version));
        
        [Required]
        [JsonPropertyName("version")]
        public string Version
        {
            get => _version.GetValue();
            set => _version.SetValue(value);
        }
    
        private PropertyValue<string?> _type = new PropertyValue<string?>(nameof(NpmPackageDependency), nameof(Type));
        
        [JsonPropertyName("type")]
        public string? Type
        {
            get => _type.GetValue();
            set => _type.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
            _type.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
