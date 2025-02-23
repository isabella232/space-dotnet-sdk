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

namespace JetBrains.Space.Client.RightDTOPartialBuilder;

public static class RightDTOPartialExtensions
{
    public static Partial<RightDTO> WithRightCode(this Partial<RightDTO> it)
        => it.AddFieldName("rightCode");
    
    public static Partial<RightDTO> WithName(this Partial<RightDTO> it)
        => it.AddFieldName("name");
    
    public static Partial<RightDTO> WithGroup(this Partial<RightDTO> it)
        => it.AddFieldName("group");
    
    public static Partial<RightDTO> WithDescription(this Partial<RightDTO> it)
        => it.AddFieldName("description");
    
    public static Partial<RightDTO> WithTargetName(this Partial<RightDTO> it)
        => it.AddFieldName("targetName");
    
    public static Partial<RightDTO> WithIsEditable(this Partial<RightDTO> it)
        => it.AddFieldName("editable");
    
    public static Partial<RightDTO> WithStatus(this Partial<RightDTO> it)
        => it.AddFieldName("status");
    
    public static Partial<RightDTO> WithStatus(this Partial<RightDTO> it, Func<Partial<RightStatus>, Partial<RightStatus>> partialBuilder)
        => it.AddFieldName("status", partialBuilder(new Partial<RightStatus>(it)));
    
    public static Partial<RightDTO> WithModificationAuthor(this Partial<RightDTO> it)
        => it.AddFieldName("modificationAuthor");
    
    public static Partial<RightDTO> WithModificationAuthor(this Partial<RightDTO> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("modificationAuthor", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<RightDTO> WithModificationTimestamp(this Partial<RightDTO> it)
        => it.AddFieldName("modificationTimestamp");
    
    public static Partial<RightDTO> WithDependencies(this Partial<RightDTO> it)
        => it.AddFieldName("dependencies");
    
}

