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
    public sealed class ProjectIssueTrackerItem
         : IPropagatePropertyAccessPath
    {
        public ProjectIssueTrackerItem() { }
        
        public ProjectIssueTrackerItem(string key, IssueTracker tracker)
        {
            Key = key;
            Tracker = tracker;
        }
        
        private PropertyValue<string> _key = new PropertyValue<string>(nameof(ProjectIssueTrackerItem), nameof(Key));
        
        [Required]
        [JsonPropertyName("key")]
        public string Key
        {
            get => _key.GetValue();
            set => _key.SetValue(value);
        }
    
        private PropertyValue<IssueTracker> _tracker = new PropertyValue<IssueTracker>(nameof(ProjectIssueTrackerItem), nameof(Tracker));
        
        [Required]
        [JsonPropertyName("tracker")]
        public IssueTracker Tracker
        {
            get => _tracker.GetValue();
            set => _tracker.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _key.SetAccessPath(path, validateHasBeenSet);
            _tracker.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
