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
    public sealed class DiffContext
         : IPropagatePropertyAccessPath
    {
        public DiffContext() { }
        
        public DiffContext(DiffSide right, DiffSide? left = null)
        {
            Left = left;
            Right = right;
        }
        
        private PropertyValue<DiffSide?> _left = new PropertyValue<DiffSide?>(nameof(DiffContext), nameof(Left));
        
        [JsonPropertyName("left")]
        public DiffSide? Left
        {
            get => _left.GetValue();
            set => _left.SetValue(value);
        }
    
        private PropertyValue<DiffSide> _right = new PropertyValue<DiffSide>(nameof(DiffContext), nameof(Right));
        
        [Required]
        [JsonPropertyName("right")]
        public DiffSide Right
        {
            get => _right.GetValue();
            set => _right.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _left.SetAccessPath(path, validateHasBeenSet);
            _right.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
