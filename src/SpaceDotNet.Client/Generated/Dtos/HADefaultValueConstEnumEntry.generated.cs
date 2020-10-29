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
    public sealed class HADefaultValueConstEnumEntry
         : HADefaultValueConst, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "HA_DefaultValue.Const.EnumEntry";
        
        public HADefaultValueConstEnumEntry() { }
        
        public HADefaultValueConstEnumEntry(string entryName)
        {
            EntryName = entryName;
        }
        
        private PropertyValue<string> _entryName = new PropertyValue<string>(nameof(HADefaultValueConstEnumEntry), nameof(EntryName));
        
        [Required]
        [JsonPropertyName("entryName")]
        public string EntryName
        {
            get => _entryName.GetValue();
            set => _entryName.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _entryName.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
