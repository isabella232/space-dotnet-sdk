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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client
{
    public class ProjectsPlanningBoardsSprintsForSprintPatchRequest
         : IPropagatePropertyAccessPath
    {
        public ProjectsPlanningBoardsSprintsForSprintPatchRequest() { }
        
        public ProjectsPlanningBoardsSprintsForSprintPatchRequest(string? name = null, string? description = null, DateTime? from = null, DateTime? to = null)
        {
            Name = name;
            Description = description;
            From = from;
            To = to;
        }
        
        private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(ProjectsPlanningBoardsSprintsForSprintPatchRequest), nameof(Name));
        
        [JsonPropertyName("name")]
        public string? Name
        {
            get => _name.GetValue();
            set => _name.SetValue(value);
        }
    
        private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsPlanningBoardsSprintsForSprintPatchRequest), nameof(Description));
        
        [JsonPropertyName("description")]
        public string? Description
        {
            get => _description.GetValue();
            set => _description.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _from = new PropertyValue<DateTime?>(nameof(ProjectsPlanningBoardsSprintsForSprintPatchRequest), nameof(From));
        
        [JsonPropertyName("from")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? From
        {
            get => _from.GetValue();
            set => _from.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _to = new PropertyValue<DateTime?>(nameof(ProjectsPlanningBoardsSprintsForSprintPatchRequest), nameof(To));
        
        [JsonPropertyName("to")]
        [JsonConverter(typeof(SpaceDateConverter))]
        public DateTime? To
        {
            get => _to.GetValue();
            set => _to.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _name.SetAccessPath(path, validateHasBeenSet);
            _description.SetAccessPath(path, validateHasBeenSet);
            _from.SetAccessPath(path, validateHasBeenSet);
            _to.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
