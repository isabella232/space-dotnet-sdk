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
    public class DRDraftDto
    {
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("title")]
        public string Title { get; set; }        
        
        [JsonPropertyName("text")]
        public string? Text { get; set; }        
        
        [JsonPropertyName("type")]
        public DraftDocumentType? Type { get; set; }        
        
        [Required]
        [JsonPropertyName("modified")]
        public SpaceTime Modified { get; set; }        
        
        [Required]
        [JsonPropertyName("publishedFlag")]
        public bool PublishedFlag { get; set; }        
        
        [Required]
        [JsonPropertyName("shared")]
        public bool Shared { get; set; }        
        
        [Required]
        [JsonPropertyName("accessOrdinal")]
        public int AccessOrdinal { get; set; }        
        
        [JsonPropertyName("publicationDetails")]
        public DraftPublicationDetailsDto? PublicationDetails { get; set; }        
        
        [JsonPropertyName("author")]
        public TDMemberProfileDto? Author { get; set; }        
        
        [Required]
        [JsonPropertyName("editors")]
        public List<TDMemberProfileDto> Editors { get; set; }        
        
        [Required]
        [JsonPropertyName("editorsTeams")]
        public List<TDTeamDto> EditorsTeams { get; set; }        
        
        [JsonPropertyName("version")]
        public long? Version { get; set; }        
        
        [JsonPropertyName("document")]
        public TextDocumentDto? Document { get; set; }        
        
    }
    
}
