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

[JsonConverter(typeof(UrlParameterConverter))]
public abstract class ChannelIdentifier : IUrlParameter
{
    public static ChannelIdentifier Application(ApplicationIdentifier application)
        => new ChannelIdentifierApplication(application);
    
    public static ChannelIdentifier Article(string article)
        => new ChannelIdentifierArticle(article);
    
    public static ChannelIdentifier Channel(ChatChannel channel)
        => new ChannelIdentifierChannel(channel);
    
    public static ChannelIdentifier ContactKey(string contactKey)
        => new ChannelIdentifierContactKey(contactKey);
    
    public static ChannelIdentifier Id(string id)
        => new ChannelIdentifierId(id);
    
    public static ChannelIdentifier Issue(IssueIdentifier issue)
        => new ChannelIdentifierIssue(issue);
    
    public static ChannelIdentifier Profile(ProfileIdentifier member)
        => new ChannelIdentifierProfile(member);
    
    public static ChannelIdentifier Review(ReviewIdentifier codeReview)
        => new ChannelIdentifierReview(codeReview);
    
    public static ChannelIdentifier Thread(string message)
        => new ChannelIdentifierThread(message);
    
    public class ChannelIdentifierApplication : ChannelIdentifier
    {
        private readonly ApplicationIdentifier _application;
        
        public ChannelIdentifierApplication(ApplicationIdentifier application)
        {
            _application = application;
        }
        
        public override string ToString()
            => $"application:{_application}";
    }
    
    public class ChannelIdentifierArticle : ChannelIdentifier
    {
        private readonly string _article;
        
        public ChannelIdentifierArticle(string article)
        {
            _article = article;
        }
        
        public override string ToString()
            => $"article:{_article}";
    }
    
    public class ChannelIdentifierChannel : ChannelIdentifier
    {
        private readonly ChatChannel _channel;
        
        public ChannelIdentifierChannel(ChatChannel channel)
        {
            _channel = channel;
        }
        
        public override string ToString()
            => $"channel:{_channel}";
    }
    
    public class ChannelIdentifierContactKey : ChannelIdentifier
    {
        private readonly string _contactKey;
        
        public ChannelIdentifierContactKey(string contactKey)
        {
            _contactKey = contactKey;
        }
        
        public override string ToString()
            => $"contactKey:{_contactKey}";
    }
    
    public class ChannelIdentifierId : ChannelIdentifier
    {
        private readonly string _id;
        
        public ChannelIdentifierId(string id)
        {
            _id = id;
        }
        
        public override string ToString()
            => $"id:{_id}";
    }
    
    public class ChannelIdentifierIssue : ChannelIdentifier
    {
        private readonly IssueIdentifier _issue;
        
        public ChannelIdentifierIssue(IssueIdentifier issue)
        {
            _issue = issue;
        }
        
        public override string ToString()
            => $"issue:{_issue}";
    }
    
    public class ChannelIdentifierProfile : ChannelIdentifier
    {
        private readonly ProfileIdentifier _member;
        
        public ChannelIdentifierProfile(ProfileIdentifier member)
        {
            _member = member;
        }
        
        public override string ToString()
            => $"member:{_member}";
    }
    
    public class ChannelIdentifierReview : ChannelIdentifier
    {
        private readonly ReviewIdentifier _codeReview;
        
        public ChannelIdentifierReview(ReviewIdentifier codeReview)
        {
            _codeReview = codeReview;
        }
        
        public override string ToString()
            => $"codeReview:{_codeReview}";
    }
    
    public class ChannelIdentifierThread : ChannelIdentifier
    {
        private readonly string _message;
        
        public ChannelIdentifierThread(string message)
        {
            _message = message;
        }
        
        public override string ToString()
            => $"message:{_message}";
    }
    
}

