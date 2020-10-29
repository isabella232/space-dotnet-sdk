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
    public class UnfurlsUnblockUnfurlGlobalPostRequest
         : IPropagatePropertyAccessPath
    {
        public UnfurlsUnblockUnfurlGlobalPostRequest() { }
        
        public UnfurlsUnblockUnfurlGlobalPostRequest(string link, bool wholeHost)
        {
            Link = link;
            IsWholeHost = wholeHost;
        }
        
        private PropertyValue<string> _link = new PropertyValue<string>(nameof(UnfurlsUnblockUnfurlGlobalPostRequest), nameof(Link));
        
        [Required]
        [JsonPropertyName("link")]
        public string Link
        {
            get => _link.GetValue();
            set => _link.SetValue(value);
        }
    
        private PropertyValue<bool> _wholeHost = new PropertyValue<bool>(nameof(UnfurlsUnblockUnfurlGlobalPostRequest), nameof(IsWholeHost));
        
        [Required]
        [JsonPropertyName("wholeHost")]
        public bool IsWholeHost
        {
            get => _wholeHost.GetValue();
            set => _wholeHost.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _link.SetAccessPath(path, validateHasBeenSet);
            _wholeHost.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
