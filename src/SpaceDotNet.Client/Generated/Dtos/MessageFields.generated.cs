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
    public sealed class MessageFields
         : MessageElement, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MessageFields";
        
        public MessageFields() { }
        
        public MessageFields(List<MessageFieldElement> fields)
        {
            Fields = fields;
        }
        
        private PropertyValue<List<MessageFieldElement>> _fields = new PropertyValue<List<MessageFieldElement>>(nameof(MessageFields), nameof(Fields));
        
        [Required]
        [JsonPropertyName("fields")]
        public List<MessageFieldElement> Fields
        {
            get => _fields.GetValue();
            set => _fields.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _fields.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
