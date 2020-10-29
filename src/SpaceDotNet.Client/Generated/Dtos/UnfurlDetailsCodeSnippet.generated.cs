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
    public sealed class UnfurlDetailsCodeSnippet
         : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "UnfurlDetailsCodeSnippet";
        
        public UnfurlDetailsCodeSnippet() { }
        
        public UnfurlDetailsCodeSnippet(CodeSnippetAnchor anchor, List<CodeLine> lines)
        {
            Anchor = anchor;
            Lines = lines;
        }
        
        private PropertyValue<CodeSnippetAnchor> _anchor = new PropertyValue<CodeSnippetAnchor>(nameof(UnfurlDetailsCodeSnippet), nameof(Anchor));
        
        [Required]
        [JsonPropertyName("anchor")]
        public CodeSnippetAnchor Anchor
        {
            get => _anchor.GetValue();
            set => _anchor.SetValue(value);
        }
    
        private PropertyValue<List<CodeLine>> _lines = new PropertyValue<List<CodeLine>>(nameof(UnfurlDetailsCodeSnippet), nameof(Lines));
        
        [Required]
        [JsonPropertyName("lines")]
        public List<CodeLine> Lines
        {
            get => _lines.GetValue();
            set => _lines.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _anchor.SetAccessPath(path, validateHasBeenSet);
            _lines.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
