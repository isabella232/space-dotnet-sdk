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
    public sealed class TeamHitDetails
         : EntityHitDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "TeamHitDetails";
        
        public TeamHitDetails() { }
        
        public TeamHitDetails(TDTeam @ref)
        {
            Ref = @ref;
        }
        
        private PropertyValue<TDTeam> _ref = new PropertyValue<TDTeam>(nameof(TeamHitDetails), nameof(Ref));
        
        [Required]
        [JsonPropertyName("ref")]
        public TDTeam Ref
        {
            get => _ref.GetValue();
            set => _ref.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _ref.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
