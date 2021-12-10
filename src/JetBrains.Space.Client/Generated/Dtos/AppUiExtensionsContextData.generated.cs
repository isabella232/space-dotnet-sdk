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

public sealed class AppUiExtensionsContextData
     : IPropagatePropertyAccessPath
{
    public AppUiExtensionsContextData() { }
    
    public AppUiExtensionsContextData(PermissionContextApi context, UsersWithEnabledAppUi usersWithEnabledAppUi, List<ApplicationUiExtensionApi>? extensions = null)
    {
        Context = context;
        Extensions = extensions;
        UsersWithEnabledAppUi = usersWithEnabledAppUi;
    }
    
    private PropertyValue<PermissionContextApi> _context = new PropertyValue<PermissionContextApi>(nameof(AppUiExtensionsContextData), nameof(Context), "context");
    
    [Required]
    [JsonPropertyName("context")]
    public PermissionContextApi Context
    {
        get => _context.GetValue(InlineErrors);
        set => _context.SetValue(value);
    }

    private PropertyValue<List<ApplicationUiExtensionApi>?> _extensions = new PropertyValue<List<ApplicationUiExtensionApi>?>(nameof(AppUiExtensionsContextData), nameof(Extensions), "extensions");
    
    [JsonPropertyName("extensions")]
    public List<ApplicationUiExtensionApi>? Extensions
    {
        get => _extensions.GetValue(InlineErrors);
        set => _extensions.SetValue(value);
    }

    private PropertyValue<UsersWithEnabledAppUi> _usersWithEnabledAppUi = new PropertyValue<UsersWithEnabledAppUi>(nameof(AppUiExtensionsContextData), nameof(UsersWithEnabledAppUi), "usersWithEnabledAppUi");
    
    [Required]
    [JsonPropertyName("usersWithEnabledAppUi")]
    public UsersWithEnabledAppUi UsersWithEnabledAppUi
    {
        get => _usersWithEnabledAppUi.GetValue(InlineErrors);
        set => _usersWithEnabledAppUi.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _context.SetAccessPath(parentChainPath, validateHasBeenSet);
        _extensions.SetAccessPath(parentChainPath, validateHasBeenSet);
        _usersWithEnabledAppUi.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

