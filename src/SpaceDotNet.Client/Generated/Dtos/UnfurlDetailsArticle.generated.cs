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
    public sealed class UnfurlDetailsArticle
         : UnfurlDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "UnfurlDetailsArticle";
        
        public UnfurlDetailsArticle() { }
        
        public UnfurlDetailsArticle(ArticleRecord article, ArticleContentRecord content, ArticleChannelRecord channel, ArticleDetailsRecord? details = null)
        {
            Article = article;
            Content = content;
            Channel = channel;
            Details = details;
        }
        
        private PropertyValue<ArticleRecord> _article = new PropertyValue<ArticleRecord>(nameof(UnfurlDetailsArticle), nameof(Article));
        
        [Required]
        [JsonPropertyName("article")]
        public ArticleRecord Article
        {
            get => _article.GetValue();
            set => _article.SetValue(value);
        }
    
        private PropertyValue<ArticleContentRecord> _content = new PropertyValue<ArticleContentRecord>(nameof(UnfurlDetailsArticle), nameof(Content));
        
        [Required]
        [JsonPropertyName("content")]
        public ArticleContentRecord Content
        {
            get => _content.GetValue();
            set => _content.SetValue(value);
        }
    
        private PropertyValue<ArticleChannelRecord> _channel = new PropertyValue<ArticleChannelRecord>(nameof(UnfurlDetailsArticle), nameof(Channel));
        
        [Required]
        [JsonPropertyName("channel")]
        public ArticleChannelRecord Channel
        {
            get => _channel.GetValue();
            set => _channel.SetValue(value);
        }
    
        private PropertyValue<ArticleDetailsRecord?> _details = new PropertyValue<ArticleDetailsRecord?>(nameof(UnfurlDetailsArticle), nameof(Details));
        
        [JsonPropertyName("details")]
        public ArticleDetailsRecord? Details
        {
            get => _details.GetValue();
            set => _details.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _article.SetAccessPath(path, validateHasBeenSet);
            _content.SetAccessPath(path, validateHasBeenSet);
            _channel.SetAccessPath(path, validateHasBeenSet);
            _details.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
