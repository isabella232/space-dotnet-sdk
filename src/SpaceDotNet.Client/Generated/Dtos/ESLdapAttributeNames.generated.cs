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
    public sealed class ESLdapAttributeNames
         : IPropagatePropertyAccessPath
    {
        public ESLdapAttributeNames() { }
        
        public ESLdapAttributeNames(string? fullNameAttributeName = null, string? usernameAttributeName = null, string? emailAttributeName = null, string? groupsAttributeName = null)
        {
            FullNameAttributeName = fullNameAttributeName;
            UsernameAttributeName = usernameAttributeName;
            EmailAttributeName = emailAttributeName;
            GroupsAttributeName = groupsAttributeName;
        }
        
        private PropertyValue<string?> _fullNameAttributeName = new PropertyValue<string?>(nameof(ESLdapAttributeNames), nameof(FullNameAttributeName));
        
        [JsonPropertyName("fullNameAttributeName")]
        public string? FullNameAttributeName
        {
            get => _fullNameAttributeName.GetValue();
            set => _fullNameAttributeName.SetValue(value);
        }
    
        private PropertyValue<string?> _usernameAttributeName = new PropertyValue<string?>(nameof(ESLdapAttributeNames), nameof(UsernameAttributeName));
        
        [JsonPropertyName("usernameAttributeName")]
        public string? UsernameAttributeName
        {
            get => _usernameAttributeName.GetValue();
            set => _usernameAttributeName.SetValue(value);
        }
    
        private PropertyValue<string?> _emailAttributeName = new PropertyValue<string?>(nameof(ESLdapAttributeNames), nameof(EmailAttributeName));
        
        [JsonPropertyName("emailAttributeName")]
        public string? EmailAttributeName
        {
            get => _emailAttributeName.GetValue();
            set => _emailAttributeName.SetValue(value);
        }
    
        private PropertyValue<string?> _groupsAttributeName = new PropertyValue<string?>(nameof(ESLdapAttributeNames), nameof(GroupsAttributeName));
        
        [JsonPropertyName("groupsAttributeName")]
        public string? GroupsAttributeName
        {
            get => _groupsAttributeName.GetValue();
            set => _groupsAttributeName.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _fullNameAttributeName.SetAccessPath(path, validateHasBeenSet);
            _usernameAttributeName.SetAccessPath(path, validateHasBeenSet);
            _emailAttributeName.SetAccessPath(path, validateHasBeenSet);
            _groupsAttributeName.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
