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

namespace JetBrains.Space.Client
{
    public partial class EmojiClient : ISpaceClient
    {
        private readonly Connection _connection;
        
        public EmojiClient(Connection connection)
        {
            _connection = connection;
        }
        
        /// <summary>
        /// Add custom emoji
        /// </summary>
        public async Task AddAsync(string emoji, string attachmentId, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("POST", $"api/http/emojis/add{queryParameters.ToQueryString()}", 
                new EmojisAddPostRequest
                { 
                    Emoji = emoji,
                    AttachmentId = attachmentId,
                }, cancellationToken);
        }
        
    
        /// <summary>
        /// Delete an emoji by name
        /// </summary>
        public async Task DeleteAsync(string emoji, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("POST", $"api/http/emojis/delete{queryParameters.ToQueryString()}", 
                new EmojisDeletePostRequest
                { 
                    Emoji = emoji,
                }, cancellationToken);
        }
        
    
        /// <summary>
        /// Record emojis usage and update frequently used list
        /// </summary>
        public async Task RecordUsageAsync(List<string> emojis, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            await _connection.RequestResourceAsync("POST", $"api/http/emojis/record-usage{queryParameters.ToQueryString()}", 
                new EmojisRecordUsagePostRequest
                { 
                    Emojis = emojis,
                }, cancellationToken);
        }
        
    
        /// <summary>
        /// Check whether a given emoji name exists
        /// </summary>
        public async Task<bool> ExistsAsync(string emoji, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            queryParameters.Append("emoji", emoji);
            
            return await _connection.RequestResourceAsync<bool>("GET", $"api/http/emojis/exists{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        /// <summary>
        /// List frequently used emojis
        /// </summary>
        public async Task<List<string>> FrequentlyUsedAsync(CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            
            return await _connection.RequestResourceAsync<List<string>>("GET", $"api/http/emojis/frequently-used{queryParameters.ToQueryString()}", cancellationToken);
        }
        
    
        /// <summary>
        /// Search for emoji
        /// </summary>
        public async Task<Batch<EmojiSearchMatchData>> SearchAsync(string query, string? skip = null, int? top = 100, Func<Partial<Batch<EmojiSearchMatchData>>, Partial<Batch<EmojiSearchMatchData>>>? partial = null, CancellationToken cancellationToken = default)
        {
            var queryParameters = new NameValueCollection();
            if (skip != null) queryParameters.Append("$skip", skip);
            if (top != null) queryParameters.Append("$top", top?.ToString());
            queryParameters.Append("query", query);
            queryParameters.Append("$fields", (partial != null ? partial(new Partial<Batch<EmojiSearchMatchData>>()) : Partial<Batch<EmojiSearchMatchData>>.Default()).ToString());
            
            return await _connection.RequestResourceAsync<Batch<EmojiSearchMatchData>>("GET", $"api/http/emojis/search{queryParameters.ToQueryString()}", cancellationToken);
        }
        
        
        /// <summary>
        /// Search for emoji
        /// </summary>
        public IAsyncEnumerable<EmojiSearchMatchData> SearchAsyncEnumerable(string query, string? skip = null, int? top = 100, Func<Partial<EmojiSearchMatchData>, Partial<EmojiSearchMatchData>>? partial = null, CancellationToken cancellationToken = default)
            => BatchEnumerator.AllItems((batchSkip, batchCancellationToken) => SearchAsync(query: query, top: top, cancellationToken: cancellationToken, skip: batchSkip, partial: builder => Partial<Batch<EmojiSearchMatchData>>.Default().WithNext().WithTotalCount().WithData(partial != null ? partial : _ => Partial<EmojiSearchMatchData>.Default())), skip, cancellationToken);
    
    }
    
}
