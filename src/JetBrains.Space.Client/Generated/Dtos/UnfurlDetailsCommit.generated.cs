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

public sealed class UnfurlDetailsCommit
     : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
{
    [JsonPropertyName("className")]
    public  string? ClassName => "UnfurlDetailsCommit";
    
    public UnfurlDetailsCommit() { }
    
    public UnfurlDetailsCommit(PRProject project, string repository, string commitId, string message, DateTime commitDate, GitAuthorInfo author, string? repositoryId = null, CommitMessageUnfurlsRecord? messageUnfurls = null, DateTime? authorDate = null, TDMemberProfile? authorProfile = null, bool? hideAuthorAndDate = null, bool? withBranchTags = null, string? reviewId = null)
    {
        Project = project;
        Repository = repository;
        RepositoryId = repositoryId;
        CommitId = commitId;
        Message = message;
        MessageUnfurls = messageUnfurls;
        CommitDate = commitDate;
        AuthorDate = authorDate;
        Author = author;
        AuthorProfile = authorProfile;
        IsHideAuthorAndDate = hideAuthorAndDate;
        IsWithBranchTags = withBranchTags;
        ReviewId = reviewId;
    }
    
    private PropertyValue<PRProject> _project = new PropertyValue<PRProject>(nameof(UnfurlDetailsCommit), nameof(Project), "project");
    
    [Required]
    [JsonPropertyName("project")]
    public PRProject Project
    {
        get => _project.GetValue(InlineErrors);
        set => _project.SetValue(value);
    }

    private PropertyValue<string> _repository = new PropertyValue<string>(nameof(UnfurlDetailsCommit), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public string Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<string?> _repositoryId = new PropertyValue<string?>(nameof(UnfurlDetailsCommit), nameof(RepositoryId), "repositoryId");
    
    [JsonPropertyName("repositoryId")]
    public string? RepositoryId
    {
        get => _repositoryId.GetValue(InlineErrors);
        set => _repositoryId.SetValue(value);
    }

    private PropertyValue<string> _commitId = new PropertyValue<string>(nameof(UnfurlDetailsCommit), nameof(CommitId), "commitId");
    
    [Required]
    [JsonPropertyName("commitId")]
    public string CommitId
    {
        get => _commitId.GetValue(InlineErrors);
        set => _commitId.SetValue(value);
    }

    private PropertyValue<string> _message = new PropertyValue<string>(nameof(UnfurlDetailsCommit), nameof(Message), "message");
    
    [Required]
    [JsonPropertyName("message")]
    public string Message
    {
        get => _message.GetValue(InlineErrors);
        set => _message.SetValue(value);
    }

    private PropertyValue<CommitMessageUnfurlsRecord?> _messageUnfurls = new PropertyValue<CommitMessageUnfurlsRecord?>(nameof(UnfurlDetailsCommit), nameof(MessageUnfurls), "messageUnfurls");
    
    [JsonPropertyName("messageUnfurls")]
    public CommitMessageUnfurlsRecord? MessageUnfurls
    {
        get => _messageUnfurls.GetValue(InlineErrors);
        set => _messageUnfurls.SetValue(value);
    }

    private PropertyValue<DateTime> _commitDate = new PropertyValue<DateTime>(nameof(UnfurlDetailsCommit), nameof(CommitDate), "commitDate");
    
    [Required]
    [JsonPropertyName("commitDate")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime CommitDate
    {
        get => _commitDate.GetValue(InlineErrors);
        set => _commitDate.SetValue(value);
    }

    private PropertyValue<DateTime?> _authorDate = new PropertyValue<DateTime?>(nameof(UnfurlDetailsCommit), nameof(AuthorDate), "authorDate");
    
    [JsonPropertyName("authorDate")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? AuthorDate
    {
        get => _authorDate.GetValue(InlineErrors);
        set => _authorDate.SetValue(value);
    }

    private PropertyValue<GitAuthorInfo> _author = new PropertyValue<GitAuthorInfo>(nameof(UnfurlDetailsCommit), nameof(Author), "author");
    
    [Required]
    [JsonPropertyName("author")]
    public GitAuthorInfo Author
    {
        get => _author.GetValue(InlineErrors);
        set => _author.SetValue(value);
    }

    private PropertyValue<TDMemberProfile?> _authorProfile = new PropertyValue<TDMemberProfile?>(nameof(UnfurlDetailsCommit), nameof(AuthorProfile), "authorProfile");
    
    [JsonPropertyName("authorProfile")]
    public TDMemberProfile? AuthorProfile
    {
        get => _authorProfile.GetValue(InlineErrors);
        set => _authorProfile.SetValue(value);
    }

    private PropertyValue<bool?> _hideAuthorAndDate = new PropertyValue<bool?>(nameof(UnfurlDetailsCommit), nameof(IsHideAuthorAndDate), "hideAuthorAndDate");
    
    [JsonPropertyName("hideAuthorAndDate")]
    public bool? IsHideAuthorAndDate
    {
        get => _hideAuthorAndDate.GetValue(InlineErrors);
        set => _hideAuthorAndDate.SetValue(value);
    }

    private PropertyValue<bool?> _withBranchTags = new PropertyValue<bool?>(nameof(UnfurlDetailsCommit), nameof(IsWithBranchTags), "withBranchTags");
    
    [JsonPropertyName("withBranchTags")]
    public bool? IsWithBranchTags
    {
        get => _withBranchTags.GetValue(InlineErrors);
        set => _withBranchTags.SetValue(value);
    }

    private PropertyValue<string?> _reviewId = new PropertyValue<string?>(nameof(UnfurlDetailsCommit), nameof(ReviewId), "reviewId");
    
    [JsonPropertyName("reviewId")]
    public string? ReviewId
    {
        get => _reviewId.GetValue(InlineErrors);
        set => _reviewId.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _project.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _repositoryId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _message.SetAccessPath(parentChainPath, validateHasBeenSet);
        _messageUnfurls.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commitDate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _authorDate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _author.SetAccessPath(parentChainPath, validateHasBeenSet);
        _authorProfile.SetAccessPath(parentChainPath, validateHasBeenSet);
        _hideAuthorAndDate.SetAccessPath(parentChainPath, validateHasBeenSet);
        _withBranchTags.SetAccessPath(parentChainPath, validateHasBeenSet);
        _reviewId.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

