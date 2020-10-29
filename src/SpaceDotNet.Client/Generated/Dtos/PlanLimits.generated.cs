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
    public sealed class PlanLimits
         : IPropagatePropertyAccessPath
    {
        public PlanLimits() { }
        
        public PlanLimits(StoragePlanLimit storage, TrafficPlanLimit traffic, PlanLimit ciCredits)
        {
            Storage = storage;
            Traffic = traffic;
            CiCredits = ciCredits;
        }
        
        private PropertyValue<StoragePlanLimit> _storage = new PropertyValue<StoragePlanLimit>(nameof(PlanLimits), nameof(Storage));
        
        [Required]
        [JsonPropertyName("storage")]
        public StoragePlanLimit Storage
        {
            get => _storage.GetValue();
            set => _storage.SetValue(value);
        }
    
        private PropertyValue<TrafficPlanLimit> _traffic = new PropertyValue<TrafficPlanLimit>(nameof(PlanLimits), nameof(Traffic));
        
        [Required]
        [JsonPropertyName("traffic")]
        public TrafficPlanLimit Traffic
        {
            get => _traffic.GetValue();
            set => _traffic.SetValue(value);
        }
    
        private PropertyValue<PlanLimit> _ciCredits = new PropertyValue<PlanLimit>(nameof(PlanLimits), nameof(CiCredits));
        
        [Required]
        [JsonPropertyName("ciCredits")]
        public PlanLimit CiCredits
        {
            get => _ciCredits.GetValue();
            set => _ciCredits.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _storage.SetAccessPath(path, validateHasBeenSet);
            _traffic.SetAccessPath(path, validateHasBeenSet);
            _ciCredits.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
