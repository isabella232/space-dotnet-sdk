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

namespace SpaceDotNet.Client
{
    public sealed class M2ChannelRecord
         : IPropagatePropertyAccessPath
    {
        public M2ChannelRecord() { }
        
        public M2ChannelRecord(string id, M2ChannelContact contact, int totalMessages, bool archived, M2ChannelRecord channel, MessageInfo? lastMessage = null, List<TDMemberProfile>? authors = null, List<CPrincipal>? commentAuthors = null, List<ChannelParticipant>? participants = null, bool? channelArchived = null, M2ChannelContentInfo? content = null, List<ChannelItemRecord>? messages = null)
        {
            Id = id;
            Contact = contact;
            TotalMessages = totalMessages;
            LastMessage = lastMessage;
            Authors = authors;
            CommentAuthors = commentAuthors;
            Participants = participants;
            IsChannelArchived = channelArchived;
            IsArchived = archived;
            Channel = channel;
            Content = content;
            Messages = messages;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(M2ChannelRecord), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get { return _id.GetValue(); }
            set { _id.SetValue(value); }
        }
    
        private PropertyValue<M2ChannelContact> _contact = new PropertyValue<M2ChannelContact>(nameof(M2ChannelRecord), nameof(Contact));
        
        [Required]
        [JsonPropertyName("contact")]
        public M2ChannelContact Contact
        {
            get { return _contact.GetValue(); }
            set { _contact.SetValue(value); }
        }
    
        private PropertyValue<int> _totalMessages = new PropertyValue<int>(nameof(M2ChannelRecord), nameof(TotalMessages));
        
        [Required]
        [JsonPropertyName("totalMessages")]
        public int TotalMessages
        {
            get { return _totalMessages.GetValue(); }
            set { _totalMessages.SetValue(value); }
        }
    
        private PropertyValue<MessageInfo?> _lastMessage = new PropertyValue<MessageInfo?>(nameof(M2ChannelRecord), nameof(LastMessage));
        
        [JsonPropertyName("lastMessage")]
        public MessageInfo? LastMessage
        {
            get { return _lastMessage.GetValue(); }
            set { _lastMessage.SetValue(value); }
        }
    
        private PropertyValue<List<TDMemberProfile>?> _authors = new PropertyValue<List<TDMemberProfile>?>(nameof(M2ChannelRecord), nameof(Authors));
        
        [JsonPropertyName("authors")]
        public List<TDMemberProfile>? Authors
        {
            get { return _authors.GetValue(); }
            set { _authors.SetValue(value); }
        }
    
        private PropertyValue<List<CPrincipal>?> _commentAuthors = new PropertyValue<List<CPrincipal>?>(nameof(M2ChannelRecord), nameof(CommentAuthors));
        
        [JsonPropertyName("commentAuthors")]
        public List<CPrincipal>? CommentAuthors
        {
            get { return _commentAuthors.GetValue(); }
            set { _commentAuthors.SetValue(value); }
        }
    
        private PropertyValue<List<ChannelParticipant>?> _participants = new PropertyValue<List<ChannelParticipant>?>(nameof(M2ChannelRecord), nameof(Participants));
        
        [JsonPropertyName("participants")]
        public List<ChannelParticipant>? Participants
        {
            get { return _participants.GetValue(); }
            set { _participants.SetValue(value); }
        }
    
        private PropertyValue<bool?> _channelArchived = new PropertyValue<bool?>(nameof(M2ChannelRecord), nameof(IsChannelArchived));
        
        [JsonPropertyName("channelArchived")]
        public bool? IsChannelArchived
        {
            get { return _channelArchived.GetValue(); }
            set { _channelArchived.SetValue(value); }
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(M2ChannelRecord), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get { return _archived.GetValue(); }
            set { _archived.SetValue(value); }
        }
    
        private PropertyValue<M2ChannelRecord> _channel = new PropertyValue<M2ChannelRecord>(nameof(M2ChannelRecord), nameof(Channel));
        
        [Required]
        [JsonPropertyName("channel")]
        public M2ChannelRecord Channel
        {
            get { return _channel.GetValue(); }
            set { _channel.SetValue(value); }
        }
    
        private PropertyValue<M2ChannelContentInfo?> _content = new PropertyValue<M2ChannelContentInfo?>(nameof(M2ChannelRecord), nameof(Content));
        
        [JsonPropertyName("content")]
        public M2ChannelContentInfo? Content
        {
            get { return _content.GetValue(); }
            set { _content.SetValue(value); }
        }
    
        private PropertyValue<List<ChannelItemRecord>?> _messages = new PropertyValue<List<ChannelItemRecord>?>(nameof(M2ChannelRecord), nameof(Messages));
        
        [JsonPropertyName("messages")]
        public List<ChannelItemRecord>? Messages
        {
            get { return _messages.GetValue(); }
            set { _messages.SetValue(value); }
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _contact.SetAccessPath(path, validateHasBeenSet);
            _totalMessages.SetAccessPath(path, validateHasBeenSet);
            _lastMessage.SetAccessPath(path, validateHasBeenSet);
            _authors.SetAccessPath(path, validateHasBeenSet);
            _commentAuthors.SetAccessPath(path, validateHasBeenSet);
            _participants.SetAccessPath(path, validateHasBeenSet);
            _channelArchived.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _channel.SetAccessPath(path, validateHasBeenSet);
            _content.SetAccessPath(path, validateHasBeenSet);
            _messages.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
