// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
#pragma warning disable CS0108

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Json.Serialization.Polymorphism;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.ArticleRecordPartialBuilder
{
    public static class ArticleRecordPartialExtensions
    {
        public static Partial<ArticleRecord> WithId(this Partial<ArticleRecord> it)
            => it.AddFieldName("id");
        
        public static Partial<ArticleRecord> WithIsArchived(this Partial<ArticleRecord> it)
            => it.AddFieldName("archived");
        
        public static Partial<ArticleRecord> WithTitle(this Partial<ArticleRecord> it)
            => it.AddFieldName("title");
        
        public static Partial<ArticleRecord> WithCreated(this Partial<ArticleRecord> it)
            => it.AddFieldName("created");
        
        public static Partial<ArticleRecord> WithAuthor(this Partial<ArticleRecord> it)
            => it.AddFieldName("author");
        
        public static Partial<ArticleRecord> WithAuthor(this Partial<ArticleRecord> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("author", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<ArticleRecord> WithAliases(this Partial<ArticleRecord> it)
            => it.AddFieldName("aliases");
        
        public static Partial<ArticleRecord> WithAliases(this Partial<ArticleRecord> it, Func<Partial<BGArticleAlias>, Partial<BGArticleAlias>> partialBuilder)
            => it.AddFieldName("aliases", partialBuilder(new Partial<BGArticleAlias>(it)));
        
        public static Partial<ArticleRecord> WithArchivedBy(this Partial<ArticleRecord> it)
            => it.AddFieldName("archivedBy");
        
        public static Partial<ArticleRecord> WithArchivedBy(this Partial<ArticleRecord> it, Func<Partial<TDMemberProfile>, Partial<TDMemberProfile>> partialBuilder)
            => it.AddFieldName("archivedBy", partialBuilder(new Partial<TDMemberProfile>(it)));
        
        public static Partial<ArticleRecord> WithArchivedAt(this Partial<ArticleRecord> it)
            => it.AddFieldName("archivedAt");
        
        public static Partial<ArticleRecord> WithChannel(this Partial<ArticleRecord> it)
            => it.AddFieldName("channel");
        
        public static Partial<ArticleRecord> WithChannel(this Partial<ArticleRecord> it, Func<Partial<M2ChannelRecord>, Partial<M2ChannelRecord>> partialBuilder)
            => it.AddFieldName("channel", partialBuilder(new Partial<M2ChannelRecord>(it)));
        
        public static Partial<ArticleRecord> WithChannelContent(this Partial<ArticleRecord> it)
            => it.AddFieldName("channelContent");
        
        public static Partial<ArticleRecord> WithChannelContent(this Partial<ArticleRecord> it, Func<Partial<M2ChannelContentRecord>, Partial<M2ChannelContentRecord>> partialBuilder)
            => it.AddFieldName("channelContent", partialBuilder(new Partial<M2ChannelContentRecord>(it)));
        
        public static Partial<ArticleRecord> WithContent(this Partial<ArticleRecord> it)
            => it.AddFieldName("content");
        
        public static Partial<ArticleRecord> WithIsEditable(this Partial<ArticleRecord> it)
            => it.AddFieldName("editable");
        
        public static Partial<ArticleRecord> WithEvent(this Partial<ArticleRecord> it)
            => it.AddFieldName("event");
        
        public static Partial<ArticleRecord> WithEvent(this Partial<ArticleRecord> it, Func<Partial<MeetingRecord>, Partial<MeetingRecord>> partialBuilder)
            => it.AddFieldName("event", partialBuilder(new Partial<MeetingRecord>(it)));
        
        public static Partial<ArticleRecord> WithExternalEntityInfo(this Partial<ArticleRecord> it)
            => it.AddFieldName("externalEntityInfo");
        
        public static Partial<ArticleRecord> WithExternalEntityInfo(this Partial<ArticleRecord> it, Func<Partial<ExternalEntityInfoRecord>, Partial<ExternalEntityInfoRecord>> partialBuilder)
            => it.AddFieldName("externalEntityInfo", partialBuilder(new Partial<ExternalEntityInfoRecord>(it)));
        
        public static Partial<ArticleRecord> WithLocation(this Partial<ArticleRecord> it)
            => it.AddFieldName("location");
        
        public static Partial<ArticleRecord> WithLocation(this Partial<ArticleRecord> it, Func<Partial<TDLocation>, Partial<TDLocation>> partialBuilder)
            => it.AddFieldName("location", partialBuilder(new Partial<TDLocation>(it)));
        
        public static Partial<ArticleRecord> WithLocations(this Partial<ArticleRecord> it)
            => it.AddFieldName("locations");
        
        public static Partial<ArticleRecord> WithLocations(this Partial<ArticleRecord> it, Func<Partial<TDLocation>, Partial<TDLocation>> partialBuilder)
            => it.AddFieldName("locations", partialBuilder(new Partial<TDLocation>(it)));
        
        public static Partial<ArticleRecord> WithPreview(this Partial<ArticleRecord> it)
            => it.AddFieldName("preview");
        
        public static Partial<ArticleRecord> WithPreviewImages(this Partial<ArticleRecord> it)
            => it.AddFieldName("previewImages");
        
        public static Partial<ArticleRecord> WithPreviewImages(this Partial<ArticleRecord> it, Func<Partial<ArticleMarkdownImage>, Partial<ArticleMarkdownImage>> partialBuilder)
            => it.AddFieldName("previewImages", partialBuilder(new Partial<ArticleMarkdownImage>(it)));
        
        public static Partial<ArticleRecord> WithProject(this Partial<ArticleRecord> it)
            => it.AddFieldName("project");
        
        public static Partial<ArticleRecord> WithProject(this Partial<ArticleRecord> it, Func<Partial<PRProject>, Partial<PRProject>> partialBuilder)
            => it.AddFieldName("project", partialBuilder(new Partial<PRProject>(it)));
        
        public static Partial<ArticleRecord> WithReactions(this Partial<ArticleRecord> it)
            => it.AddFieldName("reactions");
        
        public static Partial<ArticleRecord> WithReactions(this Partial<ArticleRecord> it, Func<Partial<AllReactionsToItemRecord>, Partial<AllReactionsToItemRecord>> partialBuilder)
            => it.AddFieldName("reactions", partialBuilder(new Partial<AllReactionsToItemRecord>(it)));
        
        public static Partial<ArticleRecord> WithTeam(this Partial<ArticleRecord> it)
            => it.AddFieldName("team");
        
        public static Partial<ArticleRecord> WithTeam(this Partial<ArticleRecord> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("team", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<ArticleRecord> WithTeams(this Partial<ArticleRecord> it)
            => it.AddFieldName("teams");
        
        public static Partial<ArticleRecord> WithTeams(this Partial<ArticleRecord> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("teams", partialBuilder(new Partial<TDTeam>(it)));
        
        public static Partial<ArticleRecord> WithWordsNumber(this Partial<ArticleRecord> it)
            => it.AddFieldName("wordsNumber");
        
    }
    
}
