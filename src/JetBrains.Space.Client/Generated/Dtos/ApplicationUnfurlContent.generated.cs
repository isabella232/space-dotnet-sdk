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
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client;

[JsonConverter(typeof(ClassNameDtoTypeConverter))]
public class ApplicationUnfurlContent
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public virtual string? ClassName => "ApplicationUnfurlContent";
    
    public static ApplicationUnfurlContentBlockMarkdown BlockMarkdown(string title, string markdown, ApiIcon? icon = null)
        => new ApplicationUnfurlContentBlockMarkdown(title: title, markdown: markdown, icon: icon);
    
    public static ApplicationUnfurlContentImage Image(string title, string url, ApiIcon? icon = null)
        => new ApplicationUnfurlContentImage(title: title, url: url, icon: icon);
    
    public static ApplicationUnfurlContentInlineMarkdown InlineMarkdown(string markdown)
        => new ApplicationUnfurlContentInlineMarkdown(markdown: markdown);
    
    public static ApplicationUnfurlContentMC MC(MessageStyle style, List<MessageSectionElement> sections, MessageOutline? outline = null)
        => new ApplicationUnfurlContentMC(style: style, sections: sections, outline: outline);
    
    public ApplicationUnfurlContent() { }
    
    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

