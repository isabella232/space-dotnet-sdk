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
    public sealed class OIDCDiscoveryError
         : OIDCDiscovery, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "OIDCDiscovery.Error";
        
        public OIDCDiscoveryError() { }
        
        public OIDCDiscoveryError(string code, string description)
        {
            Code = code;
            Description = description;
        }
        
        private PropertyValue<string> _code = new PropertyValue<string>(nameof(OIDCDiscoveryError), nameof(Code));
        
        [Required]
        [JsonPropertyName("code")]
        public string Code
        {
            get => _code.GetValue();
            set => _code.SetValue(value);
        }
    
        private PropertyValue<string> _description = new PropertyValue<string>(nameof(OIDCDiscoveryError), nameof(Description));
        
        [Required]
        [JsonPropertyName("description")]
        public string Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _code.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
