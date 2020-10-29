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
    public sealed class RightsDeps
         : IPropagatePropertyAccessPath
    {
        public RightsDeps() { }
        
        public RightsDeps(string code, List<string> deps)
        {
            Code = code;
            Deps = deps;
        }
        
        private PropertyValue<string> _code = new PropertyValue<string>(nameof(RightsDeps), nameof(Code));
        
        [Required]
        [JsonPropertyName("code")]
        public string Code
        {
            get => _code.GetValue();
            set => _code.SetValue(value);
        }
    
        private PropertyValue<List<string>> _deps = new PropertyValue<List<string>>(nameof(RightsDeps), nameof(Deps));
        
        [Required]
        [JsonPropertyName("deps")]
        public List<string> Deps
        {
            get => _deps.GetValue();
            set => _deps.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _code.SetAccessPath(path, validateHasBeenSet);
            _deps.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
