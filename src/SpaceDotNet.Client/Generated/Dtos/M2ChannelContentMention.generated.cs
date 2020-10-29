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
    public sealed class M2ChannelContentMention
         : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2ChannelContentMention";
        
        public M2ChannelContentMention() { }
        
        public M2ChannelContentMention(ChannelItemRecord record, M2ChannelRecord parent)
        {
            Record = record;
            Parent = parent;
        }
        
        private PropertyValue<ChannelItemRecord> _record = new PropertyValue<ChannelItemRecord>(nameof(M2ChannelContentMention), nameof(Record));
        
        [Required]
        [JsonPropertyName("record")]
        public ChannelItemRecord Record
        {
            get => _record.GetValue();
            set => _record.SetValue(value);
        }
    
        private PropertyValue<M2ChannelRecord> _parent = new PropertyValue<M2ChannelRecord>(nameof(M2ChannelContentMention), nameof(Parent));
        
        [Required]
        [JsonPropertyName("parent")]
        public M2ChannelRecord Parent
        {
            get => _parent.GetValue();
            set => _parent.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _record.SetAccessPath(path, validateHasBeenSet);
            _parent.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
