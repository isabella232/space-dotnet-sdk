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
public abstract class MessageRecipient : IUrlParameter
{
    public static MessageRecipient Channel(ChatChannel channel)
        => new MessageRecipientChannel(channel);
    
    public static MessageRecipient CodeReview(string codeReview)
        => new MessageRecipientCodeReview(codeReview);
    
    public static MessageRecipient Issue(string issue)
        => new MessageRecipientIssue(issue);
    
    public static MessageRecipient Member(ProfileIdentifier member)
        => new MessageRecipientMember(member);
    
    public class MessageRecipientChannel : MessageRecipient
    {
        [Required]
        [JsonPropertyName("channel")]
#if NET6_0_OR_GREATER
        public ChatChannel Channel { get; init; }
#else
        public ChatChannel Channel { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public MessageRecipientChannel() { }
#endif
        
        public MessageRecipientChannel(ChatChannel channel)
        {
            Channel = channel;
        }
        
        public override string ToString()
            => $"channel:{Channel}";
    }
    
    public class MessageRecipientCodeReview : MessageRecipient
    {
        [Required]
        [JsonPropertyName("codeReview")]
#if NET6_0_OR_GREATER
        public string CodeReview { get; init; }
#else
        public string CodeReview { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public MessageRecipientCodeReview() { }
#endif
        
        public MessageRecipientCodeReview(string codeReview)
        {
            CodeReview = codeReview;
        }
        
        public override string ToString()
            => $"codeReview:{CodeReview}";
    }
    
    public class MessageRecipientIssue : MessageRecipient
    {
        [Required]
        [JsonPropertyName("issue")]
#if NET6_0_OR_GREATER
        public string Issue { get; init; }
#else
        public string Issue { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public MessageRecipientIssue() { }
#endif
        
        public MessageRecipientIssue(string issue)
        {
            Issue = issue;
        }
        
        public override string ToString()
            => $"issue:{Issue}";
    }
    
    public class MessageRecipientMember : MessageRecipient
    {
        [Required]
        [JsonPropertyName("member")]
#if NET6_0_OR_GREATER
        public ProfileIdentifier Member { get; init; }
#else
        public ProfileIdentifier Member { get; set; }
#endif
        
#if !NET6_0_OR_GREATER
        public MessageRecipientMember() { }
#endif
        
        public MessageRecipientMember(ProfileIdentifier member)
        {
            Member = member;
        }
        
        public override string ToString()
            => $"member:{Member}";
    }
    
}

