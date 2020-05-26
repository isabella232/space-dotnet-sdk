// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client
{
    public class UpdateMeetingRequestDto
    {
        [JsonPropertyName("summary")]
        public string? Summary { get; set; }        
        
        [JsonPropertyName("description")]
        public string? Description { get; set; }        
        
        [JsonPropertyName("occurrenceRule")]
        public CalendarEventSpecDto? OccurrenceRule { get; set; }        
        
        [Required]
        [JsonPropertyName("locationsDiff")]
        public DiffDto LocationsDiff { get; set; }        
        
        [Required]
        [JsonPropertyName("profilesDiff")]
        public DiffDto ProfilesDiff { get; set; }        
        
        [Required]
        [JsonPropertyName("externalParticipantsDiff")]
        public DiffDto ExternalParticipantsDiff { get; set; }        
        
        [Required]
        [JsonPropertyName("teamsDiff")]
        public DiffDto TeamsDiff { get; set; }        
        
        [JsonPropertyName("visibility")]
        public MeetingVisibility? Visibility { get; set; }        
        
        [JsonPropertyName("modificationPreference")]
        public MeetingModificationPreference? ModificationPreference { get; set; }        
        
        [JsonPropertyName("joiningPreference")]
        public MeetingJoiningPreference? JoiningPreference { get; set; }        
        
        [Required]
        [JsonPropertyName("notifyOnExport")]
        public bool NotifyOnExport { get; set; }        
        
        [JsonPropertyName("organizer")]
        public string? Organizer { get; set; }        
        
        [JsonPropertyName("targetDate")]
        public SpaceTime? TargetDate { get; set; }        
        
        [Required]
        [JsonPropertyName("modificationKind")]
        public RecurrentModification ModificationKind { get; set; }        
        
    }
    
}
