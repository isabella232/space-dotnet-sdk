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

public sealed class ExternalIssue
     : IPropagatePropertyAccessPath
{
    public ExternalIssue() { }
    
    public ExternalIssue(string summary, string status, string externalId, string? description = null, string? assignee = null, string? externalName = null, string? externalUrl = null)
    {
        Summary = summary;
        Description = description;
        Status = status;
        Assignee = assignee;
        ExternalId = externalId;
        ExternalName = externalName;
        ExternalUrl = externalUrl;
    }
    
    private PropertyValue<string> _summary = new PropertyValue<string>(nameof(ExternalIssue), nameof(Summary), "summary");
    
    [Required]
    [JsonPropertyName("summary")]
    public string Summary
    {
        get => _summary.GetValue(InlineErrors);
        set => _summary.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ExternalIssue), nameof(Description), "description");
    
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<string> _status = new PropertyValue<string>(nameof(ExternalIssue), nameof(Status), "status");
    
    [Required]
    [JsonPropertyName("status")]
    public string Status
    {
        get => _status.GetValue(InlineErrors);
        set => _status.SetValue(value);
    }

    private PropertyValue<string?> _assignee = new PropertyValue<string?>(nameof(ExternalIssue), nameof(Assignee), "assignee");
    
    [JsonPropertyName("assignee")]
    public string? Assignee
    {
        get => _assignee.GetValue(InlineErrors);
        set => _assignee.SetValue(value);
    }

    private PropertyValue<string> _externalId = new PropertyValue<string>(nameof(ExternalIssue), nameof(ExternalId), "externalId");
    
    [Required]
    [JsonPropertyName("externalId")]
    public string ExternalId
    {
        get => _externalId.GetValue(InlineErrors);
        set => _externalId.SetValue(value);
    }

    private PropertyValue<string?> _externalName = new PropertyValue<string?>(nameof(ExternalIssue), nameof(ExternalName), "externalName");
    
    [JsonPropertyName("externalName")]
    public string? ExternalName
    {
        get => _externalName.GetValue(InlineErrors);
        set => _externalName.SetValue(value);
    }

    private PropertyValue<string?> _externalUrl = new PropertyValue<string?>(nameof(ExternalIssue), nameof(ExternalUrl), "externalUrl");
    
    [JsonPropertyName("externalUrl")]
    public string? ExternalUrl
    {
        get => _externalUrl.GetValue(InlineErrors);
        set => _externalUrl.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _summary.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _status.SetAccessPath(parentChainPath, validateHasBeenSet);
        _assignee.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _externalUrl.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

