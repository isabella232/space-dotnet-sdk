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
    public sealed class UAUserAgreement
         : IPropagatePropertyAccessPath
    {
        public UAUserAgreement() { }
        
        public UAUserAgreement(string id, string content, UAVersion version, DateTime updated)
        {
            Id = id;
            Content = content;
            Version = version;
            Updated = updated;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(UAUserAgreement), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string> _content = new PropertyValue<string>(nameof(UAUserAgreement), nameof(Content));
        
        [Required]
        [JsonPropertyName("content")]
        public string Content
        {
            get => _content.GetValue();
            set => _content.SetValue(value);
        }
    
        private PropertyValue<UAVersion> _version = new PropertyValue<UAVersion>(nameof(UAUserAgreement), nameof(Version));
        
        [Required]
        [JsonPropertyName("version")]
        public UAVersion Version
        {
            get => _version.GetValue();
            set => _version.SetValue(value);
        }
    
        private PropertyValue<DateTime> _updated = new PropertyValue<DateTime>(nameof(UAUserAgreement), nameof(Updated));
        
        [Required]
        [JsonPropertyName("updated")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Updated
        {
            get => _updated.GetValue();
            set => _updated.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _content.SetAccessPath(path, validateHasBeenSet);
            _version.SetAccessPath(path, validateHasBeenSet);
            _updated.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
