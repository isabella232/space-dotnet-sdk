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

namespace JetBrains.Space.Client.CodeReviewRecordPartialBuilder;

public static class CodeReviewRecordPartialExtensions
{
    public static Partial<CodeReviewRecord> WithId(this Partial<CodeReviewRecord> it)
        => it.AddFieldName("id");
    
    [Obsolete("Use participants (since 2020-11-03) (will be removed in a future version)")]
    public static Partial<CodeReviewRecord> WithAuthors(this Partial<CodeReviewRecord> it)
        => it.AddFieldName("authors");
    
    [Obsolete("Use participants (since 2020-11-03) (will be removed in a future version)")]
    public static Partial<CodeReviewRecord> WithAuthors(this Partial<CodeReviewRecord> it, Func<Partial<CodeReviewParticipantRecord>, Partial<CodeReviewParticipantRecord>> partialBuilder)
        => it.AddFieldName("authors", partialBuilder(new Partial<CodeReviewParticipantRecord>(it)));
    
    public static Partial<CodeReviewRecord> WithCommits(this Partial<CodeReviewRecord> it)
        => it.AddFieldName("commits");
    
    public static Partial<CodeReviewRecord> WithCommits(this Partial<CodeReviewRecord> it, Func<Partial<ReviewCommit>, Partial<ReviewCommit>> partialBuilder)
        => it.AddFieldName("commits", partialBuilder(new Partial<ReviewCommit>(it)));
    
    public static Partial<CodeReviewRecord> WithDiscussionCounter(this Partial<CodeReviewRecord> it)
        => it.AddFieldName("discussionCounter");
    
    public static Partial<CodeReviewRecord> WithDiscussionCounter(this Partial<CodeReviewRecord> it, Func<Partial<DiscussionCounter>, Partial<DiscussionCounter>> partialBuilder)
        => it.AddFieldName("discussionCounter", partialBuilder(new Partial<DiscussionCounter>(it)));
    
    public static Partial<CodeReviewRecord> WithIssueIds(this Partial<CodeReviewRecord> it)
        => it.AddFieldName("issueIds");
    
    public static Partial<CodeReviewRecord> WithParticipants(this Partial<CodeReviewRecord> it)
        => it.AddFieldName("participants");
    
    public static Partial<CodeReviewRecord> WithParticipants(this Partial<CodeReviewRecord> it, Func<Partial<CodeReviewParticipant>, Partial<CodeReviewParticipant>> partialBuilder)
        => it.AddFieldName("participants", partialBuilder(new Partial<CodeReviewParticipant>(it)));
    
    [Obsolete("Use participants (since 2020-11-03) (will be removed in a future version)")]
    public static Partial<CodeReviewRecord> WithReviewers(this Partial<CodeReviewRecord> it)
        => it.AddFieldName("reviewers");
    
    [Obsolete("Use participants (since 2020-11-03) (will be removed in a future version)")]
    public static Partial<CodeReviewRecord> WithReviewers(this Partial<CodeReviewRecord> it, Func<Partial<CodeReviewParticipantRecord>, Partial<CodeReviewParticipantRecord>> partialBuilder)
        => it.AddFieldName("reviewers", partialBuilder(new Partial<CodeReviewParticipantRecord>(it)));
    
    [Obsolete("Use participants (since 2020-11-03) (will be removed in a future version)")]
    public static Partial<CodeReviewRecord> WithWatchers(this Partial<CodeReviewRecord> it)
        => it.AddFieldName("watchers");
    
    [Obsolete("Use participants (since 2020-11-03) (will be removed in a future version)")]
    public static Partial<CodeReviewRecord> WithWatchers(this Partial<CodeReviewRecord> it, Func<Partial<CodeReviewParticipantRecord>, Partial<CodeReviewParticipantRecord>> partialBuilder)
        => it.AddFieldName("watchers", partialBuilder(new Partial<CodeReviewParticipantRecord>(it)));
    
}

