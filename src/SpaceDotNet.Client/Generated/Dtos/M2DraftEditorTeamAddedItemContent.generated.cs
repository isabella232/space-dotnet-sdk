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
    public sealed class M2DraftEditorTeamAddedItemContent
         : M2ItemContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2DraftEditorTeamAddedItemContent";
        
        public M2DraftEditorTeamAddedItemContent() { }
        
        public M2DraftEditorTeamAddedItemContent(string id, TDTeam team, string title)
        {
            Id = id;
            Team = team;
            Title = title;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(M2DraftEditorTeamAddedItemContent), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<TDTeam> _team = new PropertyValue<TDTeam>(nameof(M2DraftEditorTeamAddedItemContent), nameof(Team));
        
        [Required]
        [JsonPropertyName("team")]
        public TDTeam Team
        {
            get => _team.GetValue();
            set => _team.SetValue(value);
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(M2DraftEditorTeamAddedItemContent), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get => _title.GetValue();
            set => _title.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _team.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
