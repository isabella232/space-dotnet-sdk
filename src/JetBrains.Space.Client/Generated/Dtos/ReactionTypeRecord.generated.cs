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

public sealed class ReactionTypeRecord
     : IPropagatePropertyAccessPath
{
    public ReactionTypeRecord() { }
    
    public ReactionTypeRecord(string id, bool archived, ReactionData data, CPrincipal provider, DateTime addedAt, int? order = null)
    {
        Id = id;
        IsArchived = archived;
        Data = data;
        Provider = provider;
        AddedAt = addedAt;
        Order = order;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(ReactionTypeRecord), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(ReactionTypeRecord), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<ReactionData> _data = new PropertyValue<ReactionData>(nameof(ReactionTypeRecord), nameof(Data), "data");
    
    [Required]
    [JsonPropertyName("data")]
    public ReactionData Data
    {
        get => _data.GetValue(InlineErrors);
        set => _data.SetValue(value);
    }

    private PropertyValue<CPrincipal> _provider = new PropertyValue<CPrincipal>(nameof(ReactionTypeRecord), nameof(Provider), "provider");
    
    [Required]
    [JsonPropertyName("provider")]
    public CPrincipal Provider
    {
        get => _provider.GetValue(InlineErrors);
        set => _provider.SetValue(value);
    }

    private PropertyValue<DateTime> _addedAt = new PropertyValue<DateTime>(nameof(ReactionTypeRecord), nameof(AddedAt), "addedAt");
    
    [Required]
    [JsonPropertyName("addedAt")]
    [JsonConverter(typeof(SpaceDateConverter))]
    public DateTime AddedAt
    {
        get => _addedAt.GetValue(InlineErrors);
        set => _addedAt.SetValue(value);
    }

    private PropertyValue<int?> _order = new PropertyValue<int?>(nameof(ReactionTypeRecord), nameof(Order), "order");
    
    [JsonPropertyName("order")]
    public int? Order
    {
        get => _order.GetValue(InlineErrors);
        set => _order.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _data.SetAccessPath(parentChainPath, validateHasBeenSet);
        _provider.SetAccessPath(parentChainPath, validateHasBeenSet);
        _addedAt.SetAccessPath(parentChainPath, validateHasBeenSet);
        _order.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

