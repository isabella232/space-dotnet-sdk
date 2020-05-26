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
    public class CollabDocumentDto
         : TextDocumentDto, IClassNameConvertible
    {
        [JsonPropertyName("className")]
        public string? ClassName { get; set; }
        
        [Required]
        [JsonPropertyName("id")]
        public string Id { get; set; }        
        
        [Required]
        [JsonPropertyName("resetCounter")]
        public long ResetCounter { get; set; }        
        
        [JsonPropertyName("version")]
        public long? Version { get; set; }        
        
        [Required]
        [JsonPropertyName("type")]
        public DraftDocumentType Type { get; set; }        
        
        [Required]
        [JsonPropertyName("text")]
        public string Text { get; set; }        
        
    }
    
}
