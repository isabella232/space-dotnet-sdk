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
    public sealed class M2ChannelContentTeam
         : M2ChannelContactInfo, M2ChannelContentInfo, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2ChannelContentTeam";
        
        public M2ChannelContentTeam() { }
        
        public M2ChannelContentTeam(TDTeam team, ChannelSpecificDefaults notificationDefaults)
        {
            Team = team;
            NotificationDefaults = notificationDefaults;
        }
        
        private PropertyValue<TDTeam> _team = new PropertyValue<TDTeam>(nameof(M2ChannelContentTeam), nameof(Team));
        
        [Required]
        [JsonPropertyName("team")]
        public TDTeam Team
        {
            get => _team.GetValue();
            set => _team.SetValue(value);
        }
    
        private PropertyValue<ChannelSpecificDefaults> _notificationDefaults = new PropertyValue<ChannelSpecificDefaults>(nameof(M2ChannelContentTeam), nameof(NotificationDefaults));
        
        [Required]
        [JsonPropertyName("notificationDefaults")]
        public ChannelSpecificDefaults NotificationDefaults
        {
            get => _notificationDefaults.GetValue();
            set => _notificationDefaults.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _team.SetAccessPath(path, validateHasBeenSet);
            _notificationDefaults.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
