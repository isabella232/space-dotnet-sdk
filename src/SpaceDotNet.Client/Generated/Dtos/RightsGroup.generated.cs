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
    public sealed class RightsGroup
         : IPropagatePropertyAccessPath
    {
        public RightsGroup() { }
        
        public RightsGroup(string title, int priority, List<Right> rights)
        {
            Title = title;
            Priority = priority;
            Rights = rights;
        }
        
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(RightsGroup), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get => _title.GetValue();
            set => _title.SetValue(value);
        }
    
        private PropertyValue<int> _priority = new PropertyValue<int>(nameof(RightsGroup), nameof(Priority));
        
        [Required]
        [JsonPropertyName("priority")]
        public int Priority
        {
            get => _priority.GetValue();
            set => _priority.SetValue(value);
        }
    
        private PropertyValue<List<Right>> _rights = new PropertyValue<List<Right>>(nameof(RightsGroup), nameof(Rights));
        
        [Required]
        [JsonPropertyName("rights")]
        public List<Right> Rights
        {
            get => _rights.GetValue();
            set => _rights.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _title.SetAccessPath(path, validateHasBeenSet);
            _priority.SetAccessPath(path, validateHasBeenSet);
            _rights.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
