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
    public sealed class ProfileMembershipRecord
         : IPropagatePropertyAccessPath
    {
        public ProfileMembershipRecord() { }
        
        public ProfileMembershipRecord(string id, List<TDMembership> memberships)
        {
            Id = id;
            Memberships = memberships;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(ProfileMembershipRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<List<TDMembership>> _memberships = new PropertyValue<List<TDMembership>>(nameof(ProfileMembershipRecord), nameof(Memberships));
        
        [Required]
        [JsonPropertyName("memberships")]
        public List<TDMembership> Memberships
        {
            get => _memberships.GetValue();
            set => _memberships.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _memberships.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
