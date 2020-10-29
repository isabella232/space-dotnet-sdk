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
    public sealed class M2ChannelContentCodeReviewFeed
         : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2ChannelContentCodeReviewFeed";
        
        public M2ChannelContentCodeReviewFeed() { }
        
        public M2ChannelContentCodeReviewFeed(string codeReviewId, ChannelSpecificDefaults notificationDefaults, CodeReviewRecord? codeReview = null, CodeReviewParticipants? participants = null, CodeReviewPendingMessageCounter? pendingMessageCounter = null, PRProject? project = null)
        {
            CodeReviewId = codeReviewId;
            NotificationDefaults = notificationDefaults;
            CodeReview = codeReview;
            Participants = participants;
            PendingMessageCounter = pendingMessageCounter;
            Project = project;
        }
        
        private PropertyValue<string> _codeReviewId = new PropertyValue<string>(nameof(M2ChannelContentCodeReviewFeed), nameof(CodeReviewId));
        
        [Required]
        [JsonPropertyName("codeReviewId")]
        public string CodeReviewId
        {
            get => _codeReviewId.GetValue();
            set => _codeReviewId.SetValue(value);
        }
    
        private PropertyValue<ChannelSpecificDefaults> _notificationDefaults = new PropertyValue<ChannelSpecificDefaults>(nameof(M2ChannelContentCodeReviewFeed), nameof(NotificationDefaults));
        
        [Required]
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaults NotificationDefaults
        {
            get => _notificationDefaults.GetValue();
            set => _notificationDefaults.SetValue(value);
        }
    
        private PropertyValue<CodeReviewRecord?> _codeReview = new PropertyValue<CodeReviewRecord?>(nameof(M2ChannelContentCodeReviewFeed), nameof(CodeReview));
        
        [JsonPropertyName("codeReview")]
        public CodeReviewRecord? CodeReview
        {
            get => _codeReview.GetValue();
            set => _codeReview.SetValue(value);
        }
    
        private PropertyValue<CodeReviewParticipants?> _participants = new PropertyValue<CodeReviewParticipants?>(nameof(M2ChannelContentCodeReviewFeed), nameof(Participants));
        
        [JsonPropertyName("participants")]
        public CodeReviewParticipants? Participants
        {
            get => _participants.GetValue();
            set => _participants.SetValue(value);
        }
    
        private PropertyValue<CodeReviewPendingMessageCounter?> _pendingMessageCounter = new PropertyValue<CodeReviewPendingMessageCounter?>(nameof(M2ChannelContentCodeReviewFeed), nameof(PendingMessageCounter));
        
        [JsonPropertyName("pendingMessageCounter")]
        public CodeReviewPendingMessageCounter? PendingMessageCounter
        {
            get => _pendingMessageCounter.GetValue();
            set => _pendingMessageCounter.SetValue(value);
        }
    
        private PropertyValue<PRProject?> _project = new PropertyValue<PRProject?>(nameof(M2ChannelContentCodeReviewFeed), nameof(Project));
        
        [JsonPropertyName("project")]
        public PRProject? Project
        {
            get => _project.GetValue();
            set => _project.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _codeReviewId.SetAccessPath(path, validateHasBeenSet);
            _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
            _codeReview.SetAccessPath(path, validateHasBeenSet);
            _participants.SetAccessPath(path, validateHasBeenSet);
            _pendingMessageCounter.SetAccessPath(path, validateHasBeenSet);
            _project.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
