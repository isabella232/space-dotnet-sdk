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
    public sealed class M2PackageDeletedDetails
         : M2PackageContentDetails, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public  string? ClassName => "M2PackageDeletedDetails";
        
        public M2PackageDeletedDetails() { }
        
        public M2PackageDeletedDetails(PackageVersionInfo pkg)
        {
            Pkg = pkg;
        }
        
        private PropertyValue<PackageVersionInfo> _pkg = new PropertyValue<PackageVersionInfo>(nameof(M2PackageDeletedDetails), nameof(Pkg));
        
        [Required]
        [JsonPropertyName("pkg")]
        public PackageVersionInfo Pkg
        {
            get => _pkg.GetValue();
            set => _pkg.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _pkg.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
