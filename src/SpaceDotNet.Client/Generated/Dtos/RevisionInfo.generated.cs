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
    public sealed class RevisionInfo
         : IPropagatePropertyAccessPath
    {
        public RevisionInfo() { }
        
        public RevisionInfo(string revision, long date, string message)
        {
            Revision = revision;
            Date = date;
            Message = message;
        }
        
        private PropertyValue<string> _revision = new PropertyValue<string>(nameof(RevisionInfo), nameof(Revision));
        
        [Required]
        [JsonPropertyName("revision")]
        public string Revision
        {
            get => _revision.GetValue();
            set => _revision.SetValue(value);
        }
    
        private PropertyValue<long> _date = new PropertyValue<long>(nameof(RevisionInfo), nameof(Date));
        
        [Required]
        [JsonPropertyName("date")]
        public long Date
        {
            get => _date.GetValue();
            set => _date.SetValue(value);
        }
    
        private PropertyValue<string> _message = new PropertyValue<string>(nameof(RevisionInfo), nameof(Message));
        
        [Required]
        [JsonPropertyName("message")]
        public string Message
        {
            get => _message.GetValue();
            set => _message.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _revision.SetAccessPath(path, validateHasBeenSet);
            _date.SetAccessPath(path, validateHasBeenSet);
            _message.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
