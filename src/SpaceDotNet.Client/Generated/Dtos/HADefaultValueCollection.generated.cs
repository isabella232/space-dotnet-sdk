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
    public sealed class HADefaultValueCollection
         : HADefaultValue, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "HA_DefaultValue.Collection";
        
        public HADefaultValueCollection() { }
        
        public HADefaultValueCollection(List<HADefaultValue> elements)
        {
            Elements = elements;
        }
        
        private PropertyValue<List<HADefaultValue>> _elements = new PropertyValue<List<HADefaultValue>>(nameof(HADefaultValueCollection), nameof(Elements));
        
        [Required]
        [JsonPropertyName("elements")]
        public List<HADefaultValue> Elements
        {
            get => _elements.GetValue();
            set => _elements.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _elements.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
