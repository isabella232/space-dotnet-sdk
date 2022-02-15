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

namespace JetBrains.Space.Client.CodeDiscussionSuggestedEditPartialBuilder;

public static class CodeDiscussionSuggestedEditPartialExtensions
{
    public static Partial<CodeDiscussionSuggestedEdit> WithSuggestionCommitId(this Partial<CodeDiscussionSuggestedEdit> it)
        => it.AddFieldName("suggestionCommitId");
    
    public static Partial<CodeDiscussionSuggestedEdit> WithStatus(this Partial<CodeDiscussionSuggestedEdit> it)
        => it.AddFieldName("status");
    
    public static Partial<CodeDiscussionSuggestedEdit> WithStatus(this Partial<CodeDiscussionSuggestedEdit> it, Func<Partial<CodeDiscussionSuggestedEditState>, Partial<CodeDiscussionSuggestedEditState>> partialBuilder)
        => it.AddFieldName("status", partialBuilder(new Partial<CodeDiscussionSuggestedEditState>(it)));
    
    public static Partial<CodeDiscussionSuggestedEdit> WithResolvedBy(this Partial<CodeDiscussionSuggestedEdit> it)
        => it.AddFieldName("resolvedBy");
    
    public static Partial<CodeDiscussionSuggestedEdit> WithResolvedBy(this Partial<CodeDiscussionSuggestedEdit> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("resolvedBy", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<CodeDiscussionSuggestedEdit> WithFilePath(this Partial<CodeDiscussionSuggestedEdit> it)
        => it.AddFieldName("filePath");
    
    public static Partial<CodeDiscussionSuggestedEdit> WithIsHasConflicts(this Partial<CodeDiscussionSuggestedEdit> it)
        => it.AddFieldName("hasConflicts");
    
    public static Partial<CodeDiscussionSuggestedEdit> WithIsIdenticalContents(this Partial<CodeDiscussionSuggestedEdit> it)
        => it.AddFieldName("identicalContents");
    
    public static Partial<CodeDiscussionSuggestedEdit> WithStartLineIndex(this Partial<CodeDiscussionSuggestedEdit> it)
        => it.AddFieldName("startLineIndex");
    
    public static Partial<CodeDiscussionSuggestedEdit> WithEndLineIndexInclusive(this Partial<CodeDiscussionSuggestedEdit> it)
        => it.AddFieldName("endLineIndexInclusive");
    
}

