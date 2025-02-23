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

public sealed class ProfileOrganizationEvent
     : WebhookEvent, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "ProfileOrganizationEvent";
    
    public ProfileOrganizationEvent() { }
    
    public ProfileOrganizationEvent(KMetaMod meta, TDMemberProfile member, bool? joinedOrganization = null, bool? leftOrganization = null)
    {
        Meta = meta;
        Member = member;
        IsJoinedOrganization = joinedOrganization;
        IsLeftOrganization = leftOrganization;
    }
    
    private PropertyValue<KMetaMod> _meta = new PropertyValue<KMetaMod>(nameof(ProfileOrganizationEvent), nameof(Meta), "meta");
    
    [Required]
    [JsonPropertyName("meta")]
    public KMetaMod Meta
    {
        get => _meta.GetValue(InlineErrors);
        set => _meta.SetValue(value);
    }

    private PropertyValue<TDMemberProfile> _member = new PropertyValue<TDMemberProfile>(nameof(ProfileOrganizationEvent), nameof(Member), "member");
    
    [Required]
    [JsonPropertyName("member")]
    public TDMemberProfile Member
    {
        get => _member.GetValue(InlineErrors);
        set => _member.SetValue(value);
    }

    private PropertyValue<bool?> _joinedOrganization = new PropertyValue<bool?>(nameof(ProfileOrganizationEvent), nameof(IsJoinedOrganization), "joinedOrganization");
    
    [JsonPropertyName("joinedOrganization")]
    public bool? IsJoinedOrganization
    {
        get => _joinedOrganization.GetValue(InlineErrors);
        set => _joinedOrganization.SetValue(value);
    }

    private PropertyValue<bool?> _leftOrganization = new PropertyValue<bool?>(nameof(ProfileOrganizationEvent), nameof(IsLeftOrganization), "leftOrganization");
    
    [JsonPropertyName("leftOrganization")]
    public bool? IsLeftOrganization
    {
        get => _leftOrganization.GetValue(InlineErrors);
        set => _leftOrganization.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _meta.SetAccessPath(parentChainPath, validateHasBeenSet);
        _member.SetAccessPath(parentChainPath, validateHasBeenSet);
        _joinedOrganization.SetAccessPath(parentChainPath, validateHasBeenSet);
        _leftOrganization.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

