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
    public sealed class TDTeam
         : IPropagatePropertyAccessPath
    {
        public TDTeam() { }
        
        public TDTeam(string id, string name, string description, bool archived, Dictionary<string, CFValue> customFields, List<TDMembership> memberships, TDTeam? parent = null, List<string>? emails = null, string? channelId = null, bool? disbanded = null, DateTime? disbandedAt = null, string? externalId = null)
        {
            Id = id;
            Name = name;
            Description = description;
            Parent = parent;
            Emails = emails;
            ChannelId = channelId;
            IsArchived = archived;
            IsDisbanded = disbanded;
            DisbandedAt = disbandedAt;
            ExternalId = externalId;
            CustomFields = customFields;
            Memberships = memberships;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(TDTeam), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(TDTeam), nameof(Name));
        
        [Required]
        [JsonPropertyName("name")]
        public string Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string> _description = new PropertyValue<string>(nameof(TDTeam), nameof(Description));
        
        [Required]
        [JsonPropertyName("description")]
        public string Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<TDTeam?> _parent = new PropertyValue<TDTeam?>(nameof(TDTeam), nameof(Parent));
        
        [JsonPropertyName("parent")]
        public TDTeam? Parent
        {
            get => _parent.GetValue();
            set => _parent.SetValue(value);
        }
    
        private PropertyValue<List<string>?> _emails = new PropertyValue<List<string>?>(nameof(TDTeam), nameof(Emails));
        
        [JsonPropertyName("emails")]
        public List<string>? Emails
        {
            get => _emails.GetValue();
            set => _emails.SetValue(value);
        }
    
        private PropertyValue<string?> _channelId = new PropertyValue<string?>(nameof(TDTeam), nameof(ChannelId));
        
        [JsonPropertyName("channelId")]
        public string? ChannelId
        {
            get => _channelId.GetValue();
            set => _channelId.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(TDTeam), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<bool?> _disbanded = new PropertyValue<bool?>(nameof(TDTeam), nameof(IsDisbanded));
        
        [JsonPropertyName("disbanded")]
        public bool? IsDisbanded
        {
            get => _disbanded.GetValue();
            set => _disbanded.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _disbandedAt = new PropertyValue<DateTime?>(nameof(TDTeam), nameof(DisbandedAt));
        
        [JsonPropertyName("disbandedAt")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? DisbandedAt
        {
            get => _disbandedAt.GetValue();
            set => _disbandedAt.SetValue(value);
        }
    
        private PropertyValue<string?> _externalId = new PropertyValue<string?>(nameof(TDTeam), nameof(ExternalId));
        
        [JsonPropertyName("externalId")]
        public string? ExternalId
        {
            get => _externalId.GetValue();
            set => _externalId.SetValue(value);
        }
    
        private PropertyValue<Dictionary<string, CFValue>> _customFields = new PropertyValue<Dictionary<string, CFValue>>(nameof(TDTeam), nameof(CustomFields));
        
        [Required]
        [JsonPropertyName("customFields")]
        public Dictionary<string, CFValue> CustomFields
        {
            get => _customFields.GetValue();
            set => _customFields.SetValue(value);
        }
    
        private PropertyValue<List<TDMembership>> _memberships = new PropertyValue<List<TDMembership>>(nameof(TDTeam), nameof(Memberships));
        
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
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _parent.SetAccessPath(path, validateHasBeenSet);
            _emails.SetAccessPath(path, validateHasBeenSet);
            _channelId.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _disbanded.SetAccessPath(path, validateHasBeenSet);
            _disbandedAt.SetAccessPath(path, validateHasBeenSet);
            _externalId.SetAccessPath(path, validateHasBeenSet);
            _customFields.SetAccessPath(path, validateHasBeenSet);
            _memberships.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
