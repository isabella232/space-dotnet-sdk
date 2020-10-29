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
    public sealed class UnfurlDetailsMeeting
         : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "UnfurlDetailsMeeting";
        
        public UnfurlDetailsMeeting() { }
        
        public UnfurlDetailsMeeting(Meeting meeting)
        {
            Meeting = meeting;
        }
        
        private PropertyValue<Meeting> _meeting = new PropertyValue<Meeting>(nameof(UnfurlDetailsMeeting), nameof(Meeting));
        
        [Required]
        [JsonPropertyName("meeting")]
        public Meeting Meeting
        {
            get => _meeting.GetValue();
            set => _meeting.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _meeting.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
