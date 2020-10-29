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
    public sealed class NavBarMenuItem
         : IPropagatePropertyAccessPath
    {
        public NavBarMenuItem() { }
        
        public NavBarMenuItem(string item, bool enabled)
        {
            Item = item;
            IsEnabled = enabled;
        }
        
        private PropertyValue<string> _item = new PropertyValue<string>(nameof(NavBarMenuItem), nameof(Item));
        
        [Required]
        [JsonPropertyName("item")]
        public string Item
        {
            get => _item.GetValue();
            set => _item.SetValue(value);
        }
    
        private PropertyValue<bool> _enabled = new PropertyValue<bool>(nameof(NavBarMenuItem), nameof(IsEnabled));
        
        [Required]
        [JsonPropertyName("enabled")]
        public bool IsEnabled
        {
            get => _enabled.GetValue();
            set => _enabled.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _item.SetAccessPath(path, validateHasBeenSet);
            _enabled.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
