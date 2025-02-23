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

public class TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest
     : IPropagatePropertyAccessPath
{
    public TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest() { }
    
    public TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest(string language, string? firstName = null, string? lastName = null)
    {
        Language = language;
        FirstName = firstName;
        LastName = lastName;
    }
    
    private PropertyValue<string> _language = new PropertyValue<string>(nameof(TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest), nameof(Language), "language");
    
    [Required]
    [JsonPropertyName("language")]
    public string Language
    {
        get => _language.GetValue(InlineErrors);
        set => _language.SetValue(value);
    }

    private PropertyValue<string?> _firstName = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest), nameof(FirstName), "firstName");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("firstName")]
    public string? FirstName
    {
        get => _firstName.GetValue(InlineErrors);
        set => _firstName.SetValue(value);
    }

    private PropertyValue<string?> _lastName = new PropertyValue<string?>(nameof(TeamDirectoryProfilesForProfileSpokenLanguagesPostRequest), nameof(LastName), "lastName");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("lastName")]
    public string? LastName
    {
        get => _lastName.GetValue(InlineErrors);
        set => _lastName.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _language.SetAccessPath(parentChainPath, validateHasBeenSet);
        _firstName.SetAccessPath(parentChainPath, validateHasBeenSet);
        _lastName.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

