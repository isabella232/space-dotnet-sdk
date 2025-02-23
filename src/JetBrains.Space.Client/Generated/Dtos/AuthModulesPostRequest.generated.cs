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

public class AuthModulesPostRequest
     : IPropagatePropertyAccessPath
{
    public AuthModulesPostRequest() { }
    
    public AuthModulesPostRequest(string key, string name, bool enabled, ESAuthModuleSettings settings)
    {
        Key = key;
        Name = name;
        IsEnabled = enabled;
        Settings = settings;
    }
    
    private PropertyValue<string> _key = new PropertyValue<string>(nameof(AuthModulesPostRequest), nameof(Key), "key");
    
    [Required]
    [JsonPropertyName("key")]
    public string Key
    {
        get => _key.GetValue(InlineErrors);
        set => _key.SetValue(value);
    }

    private PropertyValue<string> _name = new PropertyValue<string>(nameof(AuthModulesPostRequest), nameof(Name), "name");
    
    [Required]
    [JsonPropertyName("name")]
    public string Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<bool> _enabled = new PropertyValue<bool>(nameof(AuthModulesPostRequest), nameof(IsEnabled), "enabled");
    
    [Required]
    [JsonPropertyName("enabled")]
    public bool IsEnabled
    {
        get => _enabled.GetValue(InlineErrors);
        set => _enabled.SetValue(value);
    }

    private PropertyValue<ESAuthModuleSettings> _settings = new PropertyValue<ESAuthModuleSettings>(nameof(AuthModulesPostRequest), nameof(Settings), "settings");
    
    [Required]
    [JsonPropertyName("settings")]
    public ESAuthModuleSettings Settings
    {
        get => _settings.GetValue(InlineErrors);
        set => _settings.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _key.SetAccessPath(parentChainPath, validateHasBeenSet);
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _enabled.SetAccessPath(parentChainPath, validateHasBeenSet);
        _settings.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

