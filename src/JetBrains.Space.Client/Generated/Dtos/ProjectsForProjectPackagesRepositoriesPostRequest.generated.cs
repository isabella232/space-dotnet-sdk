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

public class ProjectsForProjectPackagesRepositoriesPostRequest
     : IPropagatePropertyAccessPath
{
    public ProjectsForProjectPackagesRepositoriesPostRequest() { }
    
    public ProjectsForProjectPackagesRepositoriesPostRequest(string type, string name, bool @public, ESPackageRepositorySettings settings, PackageRepositoryMode mode, string? description = null, PackageRepositoryConnection? connection = null)
    {
        Type = type;
        Name = name;
        Description = description;
        IsPublic = @public;
        Settings = settings;
        Mode = mode;
        Connection = connection;
    }
    
    private PropertyValue<string> _type = new PropertyValue<string>(nameof(ProjectsForProjectPackagesRepositoriesPostRequest), nameof(Type), "type");
    
    [Required]
    [JsonPropertyName("type")]
    public string Type
    {
        get => _type.GetValue(InlineErrors);
        set => _type.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(ProjectsForProjectPackagesRepositoriesPostRequest), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(ProjectsForProjectPackagesRepositoriesPostRequest), nameof(Description), "description");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<bool> _public = new PropertyValue<bool>(nameof(ProjectsForProjectPackagesRepositoriesPostRequest), nameof(IsPublic), "public");
    
    [Required]
    [JsonPropertyName("public")]
    public bool IsPublic
    {
        get => _public.GetValue(InlineErrors);
        set => _public.SetValue(value);
    }

    private PropertyValue<ESPackageRepositorySettings> _settings = new PropertyValue<ESPackageRepositorySettings>(nameof(ProjectsForProjectPackagesRepositoriesPostRequest), nameof(Settings), "settings");
    
    [Required]
    [JsonPropertyName("settings")]
    public ESPackageRepositorySettings Settings
    {
        get => _settings.GetValue(InlineErrors);
        set => _settings.SetValue(value);
    }

    private PropertyValue<PackageRepositoryMode> _mode = new PropertyValue<PackageRepositoryMode>(nameof(ProjectsForProjectPackagesRepositoriesPostRequest), nameof(Mode), "mode");
    
    [Required]
    [JsonPropertyName("mode")]
    public PackageRepositoryMode Mode
    {
        get => _mode.GetValue(InlineErrors);
        set => _mode.SetValue(value);
    }

    private PropertyValue<PackageRepositoryConnection?> _connection = new PropertyValue<PackageRepositoryConnection?>(nameof(ProjectsForProjectPackagesRepositoriesPostRequest), nameof(Connection), "connection");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("connection")]
    public PackageRepositoryConnection? Connection
    {
        get => _connection.GetValue(InlineErrors);
        set => _connection.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _type.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _public.SetAccessPath(parentChainPath, validateHasBeenSet);
        _settings.SetAccessPath(parentChainPath, validateHasBeenSet);
        _mode.SetAccessPath(parentChainPath, validateHasBeenSet);
        _connection.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

