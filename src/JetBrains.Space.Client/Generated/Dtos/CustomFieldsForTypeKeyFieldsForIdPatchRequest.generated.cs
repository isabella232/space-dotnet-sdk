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

public class CustomFieldsForTypeKeyFieldsForIdPatchRequest
     : IPropagatePropertyAccessPath
{
    public CustomFieldsForTypeKeyFieldsForIdPatchRequest() { }
    
    public CustomFieldsForTypeKeyFieldsForIdPatchRequest(ExtendedTypeScope scope, string? name = null, string? description = null, CFConstraint? constraint = null, bool? required = null, bool? @private = null, AccessType? access = null, CFInputValue? defaultValue = null, List<EnumValueData>? enumValues = null, CFEnumValuesModification? openEnumValuesModification = null, CFUpdateParameters? cfParameters = null)
    {
        Name = name;
        Description = description;
        Constraint = constraint;
        IsRequired = required;
        IsPrivate = @private;
        Access = access;
        DefaultValue = defaultValue;
        EnumValues = enumValues;
        OpenEnumValuesModification = openEnumValuesModification;
        CfParameters = cfParameters;
        Scope = scope;
    }
    
    private PropertyValue<string?> _name = new PropertyValue<string?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(Name), "name");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("name")]
    public string? Name
    {
        get => _name.GetValue(InlineErrors);
        set => _name.SetValue(value);
    }

    private PropertyValue<string?> _description = new PropertyValue<string?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(Description), "description");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("description")]
    public string? Description
    {
        get => _description.GetValue(InlineErrors);
        set => _description.SetValue(value);
    }

    private PropertyValue<CFConstraint?> _constraint = new PropertyValue<CFConstraint?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(Constraint), "constraint");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("constraint")]
    public CFConstraint? Constraint
    {
        get => _constraint.GetValue(InlineErrors);
        set => _constraint.SetValue(value);
    }

    private PropertyValue<bool?> _required = new PropertyValue<bool?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(IsRequired), "required");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("required")]
    public bool? IsRequired
    {
        get => _required.GetValue(InlineErrors);
        set => _required.SetValue(value);
    }

    private PropertyValue<bool?> _private = new PropertyValue<bool?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(IsPrivate), "private");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("private")]
    public bool? IsPrivate
    {
        get => _private.GetValue(InlineErrors);
        set => _private.SetValue(value);
    }

    private PropertyValue<AccessType?> _access = new PropertyValue<AccessType?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(Access), "access");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("access")]
    public AccessType? Access
    {
        get => _access.GetValue(InlineErrors);
        set => _access.SetValue(value);
    }

    private PropertyValue<CFInputValue?> _defaultValue = new PropertyValue<CFInputValue?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(DefaultValue), "defaultValue");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("defaultValue")]
    public CFInputValue? DefaultValue
    {
        get => _defaultValue.GetValue(InlineErrors);
        set => _defaultValue.SetValue(value);
    }

    private PropertyValue<List<EnumValueData>?> _enumValues = new PropertyValue<List<EnumValueData>?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(EnumValues), "enumValues");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [Obsolete("Use cfParameters instead (since 2020-09-07) (will be removed in a future version)")]
    [JsonPropertyName("enumValues")]
    public List<EnumValueData>? EnumValues
    {
        get => _enumValues.GetValue(InlineErrors);
        set => _enumValues.SetValue(value);
    }

    private PropertyValue<CFEnumValuesModification?> _openEnumValuesModification = new PropertyValue<CFEnumValuesModification?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(OpenEnumValuesModification), "openEnumValuesModification");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("openEnumValuesModification")]
    public CFEnumValuesModification? OpenEnumValuesModification
    {
        get => _openEnumValuesModification.GetValue(InlineErrors);
        set => _openEnumValuesModification.SetValue(value);
    }

    private PropertyValue<CFUpdateParameters?> _cfParameters = new PropertyValue<CFUpdateParameters?>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(CfParameters), "cfParameters");
    
#if NET6_0_OR_GREATER
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingDefault)]
#endif
    [JsonPropertyName("cfParameters")]
    public CFUpdateParameters? CfParameters
    {
        get => _cfParameters.GetValue(InlineErrors);
        set => _cfParameters.SetValue(value);
    }

    private PropertyValue<ExtendedTypeScope> _scope = new PropertyValue<ExtendedTypeScope>(nameof(CustomFieldsForTypeKeyFieldsForIdPatchRequest), nameof(Scope), "scope");
    
    [Required]
    [JsonPropertyName("scope")]
    public ExtendedTypeScope Scope
    {
        get => _scope.GetValue(InlineErrors);
        set => _scope.SetValue(value);
    }

    public virtual void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _name.SetAccessPath(parentChainPath, validateHasBeenSet);
        _description.SetAccessPath(parentChainPath, validateHasBeenSet);
        _constraint.SetAccessPath(parentChainPath, validateHasBeenSet);
        _required.SetAccessPath(parentChainPath, validateHasBeenSet);
        _private.SetAccessPath(parentChainPath, validateHasBeenSet);
        _access.SetAccessPath(parentChainPath, validateHasBeenSet);
        _defaultValue.SetAccessPath(parentChainPath, validateHasBeenSet);
        _enumValues.SetAccessPath(parentChainPath, validateHasBeenSet);
        _openEnumValuesModification.SetAccessPath(parentChainPath, validateHasBeenSet);
        _cfParameters.SetAccessPath(parentChainPath, validateHasBeenSet);
        _scope.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

