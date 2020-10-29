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
    public sealed class MessageText
         : MessageElement, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "MessageText";
        
        public MessageText() { }
        
        public MessageText(string content, MessageAccessoryElement? accessory = null)
        {
            Accessory = accessory;
            Content = content;
        }
        
        private PropertyValue<MessageAccessoryElement?> _accessory = new PropertyValue<MessageAccessoryElement?>(nameof(MessageText), nameof(Accessory));
        
        [JsonPropertyName("accessory")]
        public MessageAccessoryElement? Accessory
        {
            get => _accessory.GetValue();
            set => _accessory.SetValue(value);
        }
    
        private PropertyValue<string> _content = new PropertyValue<string>(nameof(MessageText), nameof(Content));
        
        [Required]
        [JsonPropertyName("content")]
        public string Content
        {
            get => _content.GetValue();
            set => _content.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _accessory.SetAccessPath(path, validateHasBeenSet);
            _content.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
