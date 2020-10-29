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
    public sealed class TextDocument
         : IPropagatePropertyAccessPath
    {
        public TextDocument() { }
        
        public TextDocument(string id, long resetCounter, DraftDocumentType type, string text, long? version = null, string? model = null)
        {
            Id = id;
            ResetCounter = resetCounter;
            Version = version;
            Type = type;
            Text = text;
            Model = model;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(TextDocument), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<long> _resetCounter = new PropertyValue<long>(nameof(TextDocument), nameof(ResetCounter));
        
        [Required]
        [JsonPropertyName("resetCounter")]
        public long ResetCounter
        {
            get => _resetCounter.GetValue();
            set => _resetCounter.SetValue(value);
        }
    
        private PropertyValue<long?> _version = new PropertyValue<long?>(nameof(TextDocument), nameof(Version));
        
        [JsonPropertyName("version")]
        public long? Version
        {
            get => _version.GetValue();
            set => _version.SetValue(value);
        }
    
        private PropertyValue<DraftDocumentType> _type = new PropertyValue<DraftDocumentType>(nameof(TextDocument), nameof(Type));
        
        [Required]
        [JsonPropertyName("type")]
        public DraftDocumentType Type
        {
            get => _type.GetValue();
            set => _type.SetValue(value);
        }
    
        private PropertyValue<string> _text = new PropertyValue<string>(nameof(TextDocument), nameof(Text));
        
        [Required]
        [JsonPropertyName("text")]
        public string Text
        {
            get => _text.GetValue();
            set => _text.SetValue(value);
        }
    
        private PropertyValue<string?> _model = new PropertyValue<string?>(nameof(TextDocument), nameof(Model));
        
        [JsonPropertyName("model")]
        public string? Model
        {
            get => _model.GetValue();
            set => _model.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _resetCounter.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
            _type.SetAccessPath(path, validateHasBeenSet);
            _text.SetAccessPath(path, validateHasBeenSet);
            _model.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
