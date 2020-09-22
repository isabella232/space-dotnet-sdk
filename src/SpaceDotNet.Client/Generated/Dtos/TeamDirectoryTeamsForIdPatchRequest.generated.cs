// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
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
    public class TeamDirectoryTeamsForIdPatchRequest
         : IPropagatePropertyAccessPath
    {
        public TeamDirectoryTeamsForIdPatchRequest() { }
        
        public TeamDirectoryTeamsForIdPatchRequest(string name, string? description = null, List<string>? emails = null, string? parentId = null, List<CustomFieldValue>? customFieldValues = null, string? externalId = null)
        {
            Name = name;
            Description = description;
            Emails = emails;
            ParentId = parentId;
            CustomFieldValues = customFieldValues;
            ExternalId = externalId;
        }
        
        private PropertyValue<string> _name = new PropertyValue<string>(nameof(TeamDirectoryTeamsForIdPatchRequest), nameof(Name));
        
        [JsonPropertyName("name")]
        public string Name
        {
            get { return _name.GetValue(); }
            set { _name.SetValue(value); }
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(TeamDirectoryTeamsForIdPatchRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get { return _description.GetValue(); }
            set { _description.SetValue(value); }
        }
    
        private PropertyValue<List<string>?> _emails = new PropertyValue<List<string>?>(nameof(TeamDirectoryTeamsForIdPatchRequest), nameof(Emails));
        
        [JsonPropertyName("emails")]
        public List<string>? Emails
        {
            get { return _emails.GetValue(); }
            set { _emails.SetValue(value); }
        }
    
        private PropertyValue<string?> _parentId = new PropertyValue<string?>(nameof(TeamDirectoryTeamsForIdPatchRequest), nameof(ParentId));
        
        [JsonPropertyName("parentId")]
        public string? ParentId
        {
            get { return _parentId.GetValue(); }
            set { _parentId.SetValue(value); }
        }
    
        private PropertyValue<List<CustomFieldValue>?> _customFieldValues = new PropertyValue<List<CustomFieldValue>?>(nameof(TeamDirectoryTeamsForIdPatchRequest), nameof(CustomFieldValues));
        
        [JsonPropertyName("customFieldValues")]
        public List<CustomFieldValue>? CustomFieldValues
        {
            get { return _customFieldValues.GetValue(); }
            set { _customFieldValues.SetValue(value); }
        }
    
        private PropertyValue<string?> _externalId = new PropertyValue<string?>(nameof(TeamDirectoryTeamsForIdPatchRequest), nameof(ExternalId));
        
        [JsonPropertyName("externalId")]
        public string? ExternalId
        {
            get { return _externalId.GetValue(); }
            set { _externalId.SetValue(value); }
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _emails.SetAccessPath(path, validateHasBeenSet);
            _parentId.SetAccessPath(path, validateHasBeenSet);
            _customFieldValues.SetAccessPath(path, validateHasBeenSet);
            _externalId.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
