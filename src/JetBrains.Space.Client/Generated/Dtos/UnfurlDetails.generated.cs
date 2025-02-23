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

public interface UnfurlDetails
     : IClassNameConvertible, IPropagatePropertyAccessPath
{
    public static AutomationJobExecutionUnfurlDetails AutomationJobExecution(string jobExecutionId, PRProject projectRef, string repoName)
        => new AutomationJobExecutionUnfurlDetails(jobExecutionId: jobExecutionId, projectRef: projectRef, repoName: repoName);
    
    public static AutomationJobUnfurlDetails AutomationJob(string jobId, string jobName, PRProject projectRef, string repoName, JobExecutionDisplayStatus? jobExecutionDisplayStatusFilter = null, JobTriggerType? jobTriggerFilter = null, Branch? branch = null)
        => new AutomationJobUnfurlDetails(jobId: jobId, jobName: jobName, projectRef: projectRef, repoName: repoName, jobExecutionDisplayStatusFilter: jobExecutionDisplayStatusFilter, jobTriggerFilter: jobTriggerFilter, branch: branch);
    
    public static CallSessionUnfurlDetails CallSession(CallSession session)
        => new CallSessionUnfurlDetails(session: session);
    
    public static ChannelItemSnapshot ChannelItemSnapshot(string id, string text, CPrincipal author, DateTime created, long time, string? channelId = null, M2ItemContentDetails? details = null, List<AttachmentInfo>? attachments = null, List<EntityMention>? mentions = null)
        => new ChannelItemSnapshot(id: id, text: text, author: author, created: created, time: time, channelId: channelId, details: details, attachments: attachments, mentions: mentions);
    
    public static DocumentHistoryUnfurlDetails DocumentHistory(string document, string title, DateTime? version = null, DateTime? @base = null, DateTime? preview = null)
        => new DocumentHistoryUnfurlDetails(document: document, title: title, version: version, @base: @base, preview: preview);
    
    public static UnfurlDetailsApplication Application(ESApp app)
        => new UnfurlDetailsApplication(app: app);
    
    public static UnfurlDetailsArticle Article(ArticleRecord article, ArticleContentRecord? content = null, ArticleChannelRecord? channel = null, ArticleDetailsRecord? details = null)
        => new UnfurlDetailsArticle(article: article, content: content, channel: channel, details: details);
    
    public static UnfurlDetailsBlockMarkdown BlockMarkdown(string title, string markdown, string? icon = null)
        => new UnfurlDetailsBlockMarkdown(title: title, markdown: markdown, icon: icon);
    
    public static UnfurlDetailsChat Chat(string channel, string title)
        => new UnfurlDetailsChat(channel: channel, title: title);
    
    public static UnfurlDetailsChatLink ChatLink(string contactKey, string title)
        => new UnfurlDetailsChatLink(contactKey: contactKey, title: title);
    
    public static UnfurlDetailsChecklist Checklist(Checklist checklist)
        => new UnfurlDetailsChecklist(checklist: checklist);
    
    public static UnfurlDetailsCodeReview CodeReview(CodeReviewRecord review, bool withBranchPair, bool? withIcon = null, string? defaultBranchInRepo = null, bool? hideIfCannotResolve = null, CodeReviewState? reviewState = null, bool? isMerged = null)
        => new UnfurlDetailsCodeReview(review: review, withBranchPair: withBranchPair, withIcon: withIcon, defaultBranchInRepo: defaultBranchInRepo, hideIfCannotResolve: hideIfCannotResolve, reviewState: reviewState, isMerged: isMerged);
    
    public static UnfurlDetailsCodeSnippet CodeSnippet(CodeSnippetAnchor anchor, List<CodeLine> lines)
        => new UnfurlDetailsCodeSnippet(anchor: anchor, lines: lines);
    
    public static UnfurlDetailsCommit Commit(PRProject project, string repository, string commitId, string message, DateTime commitDate, GitAuthorInfo author, string? repositoryId = null, CommitMessageUnfurlsRecord? messageUnfurls = null, DateTime? authorDate = null, TDMemberProfile? authorProfile = null, bool? hideAuthorAndDate = null, bool? withBranchTags = null, string? reviewId = null)
        => new UnfurlDetailsCommit(project: project, repository: repository, commitId: commitId, message: message, commitDate: commitDate, author: author, repositoryId: repositoryId, messageUnfurls: messageUnfurls, authorDate: authorDate, authorProfile: authorProfile, hideAuthorAndDate: hideAuthorAndDate, withBranchTags: withBranchTags, reviewId: reviewId);
    
    public static UnfurlDetailsDateTime DateTime(long utcMilliseconds, DateTimeViewParams? @params = null)
        => new UnfurlDetailsDateTime(utcMilliseconds: utcMilliseconds, @params: @params);
    
    public static UnfurlDetailsDateTimeRange DateTimeRange(long since, long till, DateTimeViewParams? @params = null)
        => new UnfurlDetailsDateTimeRange(since: since, till: till, @params: @params);
    
    public static UnfurlDetailsDraft Draft(string draft, string title, Document? document = null, bool? strikeThrough = null)
        => new UnfurlDetailsDraft(draft: draft, title: title, document: document, strikeThrough: strikeThrough);
    
    public static UnfurlDetailsFolder Folder(string name, bool root)
        => new UnfurlDetailsFolder(name: name, root: root);
    
    public static UnfurlDetailsImage Image(string title, ImageAttachment image, string? icon = null)
        => new UnfurlDetailsImage(title: title, image: image, icon: icon);
    
    public static UnfurlDetailsInlineMarkdown InlineMarkdown(string markdown)
        => new UnfurlDetailsInlineMarkdown(markdown: markdown);
    
    public static UnfurlDetailsIssue Issue(Issue issue, bool? strikeThrough = null, bool? compact = null)
        => new UnfurlDetailsIssue(issue: issue, strikeThrough: strikeThrough, compact: compact);
    
    public static UnfurlDetailsIssueStatus IssueStatus(IssueStatus status)
        => new UnfurlDetailsIssueStatus(status: status);
    
    public static UnfurlDetailsIssueTag IssueTag(PlanningTag tag, bool strikeThrough)
        => new UnfurlDetailsIssueTag(tag: tag, strikeThrough: strikeThrough);
    
    public static UnfurlDetailsIssueTopic IssueTopic(Topic topic, bool strikeThrough)
        => new UnfurlDetailsIssueTopic(topic: topic, strikeThrough: strikeThrough);
    
    public static UnfurlDetailsLocation Location(TDLocation location, bool? strikeThrough = null)
        => new UnfurlDetailsLocation(location: location, strikeThrough: strikeThrough);
    
    public static UnfurlDetailsMC MC(MCMessage message, List<AttachmentInfo>? inlineUnfurls = null)
        => new UnfurlDetailsMC(message: message, inlineUnfurls: inlineUnfurls);
    
    public static UnfurlDetailsMeeting Meeting(Meeting meeting, bool? compact = null)
        => new UnfurlDetailsMeeting(meeting: meeting, compact: compact);
    
    public static UnfurlDetailsPackageDetails PackageDetails(ProjectPackageRepository repoRef, string? packageName = null, string? version = null)
        => new UnfurlDetailsPackageDetails(repoRef: repoRef, packageName: packageName, version: version);
    
    public static UnfurlDetailsProfile Profile(TDMemberProfile profile, bool? strikeThrough = null)
        => new UnfurlDetailsProfile(profile: profile, strikeThrough: strikeThrough);
    
    public static UnfurlDetailsProject Project(PRProject project, bool? strikeThrough = null)
        => new UnfurlDetailsProject(project: project, strikeThrough: strikeThrough);
    
    public static UnfurlDetailsRepositoryBranch RepositoryBranch(PRProject project, string repository, string branchHead, bool deleted, bool? isDefault = null)
        => new UnfurlDetailsRepositoryBranch(project: project, repository: repository, branchHead: branchHead, deleted: deleted, isDefault: isDefault);
    
    public static UnfurlDetailsRole Role(TDRole role)
        => new UnfurlDetailsRole(role: role);
    
    public static UnfurlDetailsShortCommit ShortCommit(PRProject project, string repository, string commitId, string message, bool strikeThrough)
        => new UnfurlDetailsShortCommit(project: project, repository: repository, commitId: commitId, message: message, strikeThrough: strikeThrough);
    
    public static UnfurlDetailsSnapshotDiff SnapshotDiff(string snapshotId, string baseSnapshotId)
        => new UnfurlDetailsSnapshotDiff(snapshotId: snapshotId, baseSnapshotId: baseSnapshotId);
    
    public static UnfurlDetailsSprint Sprint(PRProject project, SprintRecord sprint)
        => new UnfurlDetailsSprint(project: project, sprint: sprint);
    
    public static UnfurlDetailsTeam Team(TDTeam team, bool? strikeThrough = null)
        => new UnfurlDetailsTeam(team: team, strikeThrough: strikeThrough);
    
}

