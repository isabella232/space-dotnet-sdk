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

public class ApplicationsForApplicationUnfurlPatternsAuthorizePostRequest
     : IPropagatePropertyAccessPath
{
    public ApplicationsForApplicationUnfurlPatternsAuthorizePostRequest() { }
    
    public ApplicationsForApplicationUnfurlPatternsAuthorizePostRequest(List<string> patterns, bool approve)
    {
        Patterns = patterns;
        IsApprove = approve;
    }
    
    private PropertyValue<List<string>> _patterns = new PropertyValue<List<string>>(nameof(ApplicationsForApplicationUnfurlPatternsAuthorizePostRequest), nameof(Patterns), "patterns", new List<string>());
    
    [Required]
    [JsonPropertyName("patterns")]
    public List<string> Patterns
    {
        get => _patterns.GetValue(InlineErrors);
        set => _patterns.SetValue(value);
    }

    private PropertyValue<bool> _approve = new PropertyValue<bool>(nameof(ApplicationsForApplicationUnfurlPatternsAuthorizePostRequest), nameof(IsApprove), "approve");
    
    [Required]
    [JsonPropertyName("approve")]
    public bool IsApprove
    {
        get => _approve.GetValue(InlineErrors);
        set => _approve.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _patterns.SetAccessPath(parentChainPath, validateHasBeenSet);
        _approve.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

