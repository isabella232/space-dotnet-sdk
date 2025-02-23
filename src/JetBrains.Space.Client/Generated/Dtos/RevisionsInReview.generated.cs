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

public sealed class RevisionsInReview
     : IPropagatePropertyAccessPath
{
    public RevisionsInReview() { }
    
    public RevisionsInReview(RepositoryInReview repository, List<GitCommitWithGraph> commits)
    {
        Repository = repository;
        Commits = commits;
    }
    
    private PropertyValue<RepositoryInReview> _repository = new PropertyValue<RepositoryInReview>(nameof(RevisionsInReview), nameof(Repository), "repository");
    
    [Required]
    [JsonPropertyName("repository")]
    public RepositoryInReview Repository
    {
        get => _repository.GetValue(InlineErrors);
        set => _repository.SetValue(value);
    }

    private PropertyValue<List<GitCommitWithGraph>> _commits = new PropertyValue<List<GitCommitWithGraph>>(nameof(RevisionsInReview), nameof(Commits), "commits", new List<GitCommitWithGraph>());
    
    [Required]
    [JsonPropertyName("commits")]
    public List<GitCommitWithGraph> Commits
    {
        get => _commits.GetValue(InlineErrors);
        set => _commits.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _repository.SetAccessPath(parentChainPath, validateHasBeenSet);
        _commits.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

