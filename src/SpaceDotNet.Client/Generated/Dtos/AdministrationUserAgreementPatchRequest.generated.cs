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
    public class AdministrationUserAgreementPatchRequest
         : IPropagatePropertyAccessPath
    {
        public AdministrationUserAgreementPatchRequest() { }
        
        public AdministrationUserAgreementPatchRequest(string newContent, bool invalidate)
        {
            NewContent = newContent;
            IsInvalidate = invalidate;
        }
        
        private PropertyValue<string> _newContent = new PropertyValue<string>(nameof(AdministrationUserAgreementPatchRequest), nameof(NewContent));
        
        [Required]
        [JsonPropertyName("newContent")]
        public string NewContent
        {
            get => _newContent.GetValue();
            set => _newContent.SetValue(value);
        }
    
        private PropertyValue<bool> _invalidate = new PropertyValue<bool>(nameof(AdministrationUserAgreementPatchRequest), nameof(IsInvalidate));
        
        [Required]
        [JsonPropertyName("invalidate")]
        public bool IsInvalidate
        {
            get => _invalidate.GetValue();
            set => _invalidate.SetValue(value);
        }
    
        public virtual void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _newContent.SetAccessPath(path, validateHasBeenSet);
            _invalidate.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
