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

public sealed class ChannelItemSnapshot
     : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ChannelItemSnapshot";
    
    public ChannelItemSnapshot() { }
    
    public ChannelItemSnapshot(string id, string text, CPrincipal author, DateTime created, long time, string? channelId = null, M2ItemContentDetails? details = null, List<AttachmentInfo>? attachments = null, List<EntityMention>? mentions = null)
    {
        Id = id;
        ChannelId = channelId;
        Text = text;
        Details = details;
        Author = author;
        Created = created;
        Time = time;
        Attachments = attachments;
        Mentions = mentions;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(ChannelItemSnapshot), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<string?> _channelId = new PropertyValue<string?>(nameof(ChannelItemSnapshot), nameof(ChannelId), "channelId");
    
    [JsonPropertyName("channelId")]
    public string? ChannelId
    {
        get => _channelId.GetValue(InlineErrors);
        set => _channelId.SetValue(value);
    }

    private PropertyValue<string> _text = new PropertyValue<string>(nameof(ChannelItemSnapshot), nameof(Text), "text");
    
    [Required]
    [JsonPropertyName("text")]
    public string Text
    {
        get => _text.GetValue(InlineErrors);
        set => _text.SetValue(value);
    }

    private PropertyValue<M2ItemContentDetails?> _details = new PropertyValue<M2ItemContentDetails?>(nameof(ChannelItemSnapshot), nameof(Details), "details");
    
    [JsonPropertyName("details")]
    public M2ItemContentDetails? Details
    {
        get => _details.GetValue(InlineErrors);
        set => _details.SetValue(value);
    }

    private PropertyValue<CPrincipal> _author = new PropertyValue<CPrincipal>(nameof(ChannelItemSnapshot), nameof(Author), "author");
    
    [Required]
    [JsonPropertyName("author")]
    public CPrincipal Author
    {
        get => _author.GetValue(InlineErrors);
        set => _author.SetValue(value);
    }

    private PropertyValue<DateTime> _created = new PropertyValue<DateTime>(nameof(ChannelItemSnapshot), nameof(Created), "created");
    
    [Required]
    [JsonPropertyName("created")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Created
    {
        get => _created.GetValue(InlineErrors);
        set => _created.SetValue(value);
    }

    private PropertyValue<long> _time = new PropertyValue<long>(nameof(ChannelItemSnapshot), nameof(Time), "time");
    
    [Required]
    [JsonPropertyName("time")]
    public long Time
    {
        get => _time.GetValue(InlineErrors);
        set => _time.SetValue(value);
    }

    private PropertyValue<List<AttachmentInfo>?> _attachments = new PropertyValue<List<AttachmentInfo>?>(nameof(ChannelItemSnapshot), nameof(Attachments), "attachments");
    
    [JsonPropertyName("attachments")]
    public List<AttachmentInfo>? Attachments
    {
        get => _attachments.GetValue(InlineErrors);
        set => _attachments.SetValue(value);
    }

    private PropertyValue<List<EntityMention>?> _mentions = new PropertyValue<List<EntityMention>?>(nameof(ChannelItemSnapshot), nameof(Mentions), "mentions");
    
    [JsonPropertyName("mentions")]
    public List<EntityMention>? Mentions
    {
        get => _mentions.GetValue(InlineErrors);
        set => _mentions.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _channelId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _text.SetAccessPath(parentChainPath, validateHasBeenSet);
        _details.SetAccessPath(parentChainPath, validateHasBeenSet);
        _author.SetAccessPath(parentChainPath, validateHasBeenSet);
        _created.SetAccessPath(parentChainPath, validateHasBeenSet);
        _time.SetAccessPath(parentChainPath, validateHasBeenSet);
        _attachments.SetAccessPath(parentChainPath, validateHasBeenSet);
        _mentions.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

