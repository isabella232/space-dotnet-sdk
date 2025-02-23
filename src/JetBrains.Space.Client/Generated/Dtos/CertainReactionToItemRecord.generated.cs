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

public sealed class CertainReactionToItemRecord
     : IPropagatePropertyAccessPath
{
    public CertainReactionToItemRecord() { }
    
    public CertainReactionToItemRecord(string id, string itemId, ReactionTypeRecord reaction, int count, bool meReacted, List<CPrincipal> principals, long? order = null)
    {
        Id = id;
        ItemId = itemId;
        Reaction = reaction;
        Count = count;
        IsMeReacted = meReacted;
        Principals = principals;
        Order = order;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(CertainReactionToItemRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<string> _itemId = new PropertyValue<string>(nameof(CertainReactionToItemRecord), nameof(ItemId), "itemId");
    
    [Required]
    [JsonPropertyName("itemId")]
    public string ItemId
    {
        get => _itemId.GetValue(InlineErrors);
        set => _itemId.SetValue(value);
    }

    private PropertyValue<ReactionTypeRecord> _reaction = new PropertyValue<ReactionTypeRecord>(nameof(CertainReactionToItemRecord), nameof(Reaction), "reaction");
    
    [Required]
    [JsonPropertyName("reaction")]
    public ReactionTypeRecord Reaction
    {
        get => _reaction.GetValue(InlineErrors);
        set => _reaction.SetValue(value);
    }

    private PropertyValue<int> _count = new PropertyValue<int>(nameof(CertainReactionToItemRecord), nameof(Count), "count");
    
    [Required]
    [JsonPropertyName("count")]
    public int Count
    {
        get => _count.GetValue(InlineErrors);
        set => _count.SetValue(value);
    }

    private PropertyValue<bool> _meReacted = new PropertyValue<bool>(nameof(CertainReactionToItemRecord), nameof(IsMeReacted), "meReacted");
    
    [Required]
    [JsonPropertyName("meReacted")]
    public bool IsMeReacted
    {
        get => _meReacted.GetValue(InlineErrors);
        set => _meReacted.SetValue(value);
    }

    private PropertyValue<List<CPrincipal>> _principals = new PropertyValue<List<CPrincipal>>(nameof(CertainReactionToItemRecord), nameof(Principals), "principals", new List<CPrincipal>());
    
    [Required]
    [JsonPropertyName("principals")]
    public List<CPrincipal> Principals
    {
        get => _principals.GetValue(InlineErrors);
        set => _principals.SetValue(value);
    }

    private PropertyValue<long?> _order = new PropertyValue<long?>(nameof(CertainReactionToItemRecord), nameof(Order), "order");
    
    [JsonPropertyName("order")]
    public long? Order
    {
        get => _order.GetValue(InlineErrors);
        set => _order.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _itemId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _reaction.SetAccessPath(parentChainPath, validateHasBeenSet);
        _count.SetAccessPath(parentChainPath, validateHasBeenSet);
        _meReacted.SetAccessPath(parentChainPath, validateHasBeenSet);
        _principals.SetAccessPath(parentChainPath, validateHasBeenSet);
        _order.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

