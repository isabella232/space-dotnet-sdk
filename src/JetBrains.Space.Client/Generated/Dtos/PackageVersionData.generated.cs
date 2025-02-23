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

public sealed class PackageVersionData
     : IPropagatePropertyAccessPath
{
    public PackageVersionData() { }
    
    public PackageVersionData(PackageType type, string repository, string name, string version, bool pinned, List<string>? tags = null, long? created = null, long? lastAccessed = null, long? downloads = null, string? comment = null, long? diskSize = null)
    {
        Type = type;
        Repository = repository;
        Name = name;
        Version = version;
        Tags = tags;
        Created = created;
        LastAccessed = lastAccessed;
        Downloads = downloads;
        IsPinned = pinned;
        Comment = comment;
        DiskSize = diskSize;
    }
    
    private PropertyValue<PackageType> _type = new PropertyValue<PackageType>(nameof(PackageVersionData), nameof(Type), "type");
    
    [Required]
    [JsonPropertyName("type")]
    public PackageType Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(PackageVersionData), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(PackageVersionData), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string> _version = new PropertyValue<string>(nameof(PackageVersionData), nameof(Version), "version");
    
    [Required]
    [JsonPropertyName("version")]
    public string Version
    {
        get => _version.GetValue(InlineErrors);
        set => _version.SetValue(value);
    }

    private PropertyValue<List<string>?> _tags = new PropertyValue<List<string>?>(nameof(PackageVersionData), nameof(Tags), "tags");
    
    [JsonPropertyName("tags")]
    public List<string>? Tags
    {
        get => _tags.GetValue(InlineErrors);
        set => _tags.SetValue(value);
    }

    private PropertyValue<long?> _created = new PropertyValue<long?>(nameof(PackageVersionData), nameof(Created), "created");
    
    [JsonPropertyName("created")]
    public long? Created
    {
        get => _created.GetValue(InlineErrors);
        set => _created.SetValue(value);
    }

    private PropertyValue<long?> _lastAccessed = new PropertyValue<long?>(nameof(PackageVersionData), nameof(LastAccessed), "lastAccessed");
    
    [JsonPropertyName("lastAccessed")]
    public long? LastAccessed
    {
        get => _lastAccessed.GetValue(InlineErrors);
        set => _lastAccessed.SetValue(value);
    }

    private PropertyValue<long?> _downloads = new PropertyValue<long?>(nameof(PackageVersionData), nameof(Downloads), "downloads");
    
    [JsonPropertyName("downloads")]
    public long? Downloads
    {
        get => _downloads.GetValue(InlineErrors);
        set => _downloads.SetValue(value);
    }

    private PropertyValue<bool> _pinned = new PropertyValue<bool>(nameof(PackageVersionData), nameof(IsPinned), "pinned");
    
    [Required]
    [JsonPropertyName("pinned")]
    public bool IsPinned
    {
        get => _pinned.GetValue(InlineErrors);
        set => _pinned.SetValue(value);
    }

    private PropertyValue<string?> _comment = new PropertyValue<string?>(nameof(PackageVersionData), nameof(Comment), "comment");
    
    [JsonPropertyName("comment")]
    public string? Comment
    {
        get => _comment.GetValue(InlineErrors);
        set => _comment.SetValue(value);
    }

    private PropertyValue<long?> _diskSize = new PropertyValue<long?>(nameof(PackageVersionData), nameof(DiskSize), "diskSize");
    
    [JsonPropertyName("diskSize")]
    public long? DiskSize
    {
        get => _diskSize.GetValue(InlineErrors);
        set => _diskSize.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _version.SetAccessPath(parentChainPath, validateHasBeenSet);
        _tags.SetAccessPath(parentChainPath, validateHasBeenSet);
        _created.SetAccessPath(parentChainPath, validateHasBeenSet);
        _lastAccessed.SetAccessPath(parentChainPath, validateHasBeenSet);
        _downloads.SetAccessPath(parentChainPath, validateHasBeenSet);
        _pinned.SetAccessPath(parentChainPath, validateHasBeenSet);
        _comment.SetAccessPath(parentChainPath, validateHasBeenSet);
        _diskSize.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

