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

public class ProjectsForProjectPatchRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectPatchRequest() { }
    
    public ProjectsForProjectPatchRequest(ProjectKey? key = null, string? name = null, string? description = null, bool? @private = null, List<string>? tags = null, string? icon = null)
    {
        Key = key;
        Name = name;
        Description = description;
        IsPrivate = @private;
        Tags = tags;
        Icon = icon;
    }
    
    private PropertyValue<ProjectKey?> _key = new PropertyValue<ProjectKey?>(nameof(ProjectsForProjectPatchRequest), nameof(Key), "key");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("key")]
    public ProjectKey? Key
    {
        get => _key.GetValue(InlineErrors);
        set => _key.SetValue(value);
    }

    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(ProjectsForProjectPatchRequest), nameof(Name), "name");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsForProjectPatchRequest), nameof(Description), "description");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<bool?> _private = new PropertyValue<bool?>(nameof(ProjectsForProjectPatchRequest), nameof(IsPrivate), "private");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("private")]
    public bool? IsPrivate
    {
        get => _private.GetValue(InlineErrors);
        set => _private.SetValue(value);
    }

    private PropertyValue<List<string>?> _tags = new PropertyValue<List<string>?>(nameof(ProjectsForProjectPatchRequest), nameof(Tags), "tags");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("tags")]
    public List<string>? Tags
    {
        get => _tags.GetValue(InlineErrors);
        set => _tags.SetValue(value);
    }

    private PropertyValue<string?> _icon = new PropertyValue<string?>(nameof(ProjectsForProjectPatchRequest), nameof(Icon), "icon");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("icon")]
    public string? Icon
    {
        get => _icon.GetValue(InlineErrors);
        set => _icon.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _key.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _private.SetAccessPath(parentChainPath, validateHasBeenSet);
        _tags.SetAccessPath(parentChainPath, validateHasBeenSet);
        _icon.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

