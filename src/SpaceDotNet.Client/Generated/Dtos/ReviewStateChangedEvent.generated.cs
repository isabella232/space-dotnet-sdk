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
    public sealed class ReviewStateChangedEvent
         : FeedEvent, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "ReviewStateChangedEvent";
        
        public ReviewStateChangedEvent() { }
        
        public ReviewStateChangedEvent(CodeReviewState state, CodeReviewRecord? review = null)
        {
            State = state;
            Review = review;
        }
        
        private PropertyValue<CodeReviewState> _state = new PropertyValue<CodeReviewState>(nameof(ReviewStateChangedEvent), nameof(State));
        
        [Required]
        [JsonPropertyName("state")]
        public CodeReviewState State
        {
            get => _state.GetValue();
            set => _state.SetValue(value);
        }
    
        private PropertyValue<CodeReviewRecord?> _review = new PropertyValue<CodeReviewRecord?>(nameof(ReviewStateChangedEvent), nameof(Review));
        
        [JsonPropertyName("review")]
        public CodeReviewRecord? Review
        {
            get => _review.GetValue();
            set => _review.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _state.SetAccessPath(path, validateHasBeenSet);
            _review.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
