// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using SpaceDotNet.Client.Internal;
using SpaceDotNet.Common;
using SpaceDotNet.Common.Json.Serialization;
using SpaceDotNet.Common.Types;

namespace SpaceDotNet.Client.DiffExtensions
{
    public static class DiffDtoPartialExtensions
    {
        public static Partial<DiffDto> WithAdded(this Partial<DiffDto> it)
            => it.AddFieldName("added");
        
        public static Partial<DiffDto> WithAdded(this Partial<DiffDto> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("added", partialBuilder(new Partial<string>()));
        
        public static Partial<DiffDto> WithRemoved(this Partial<DiffDto> it)
            => it.AddFieldName("removed");
        
        public static Partial<DiffDto> WithRemoved(this Partial<DiffDto> it, Func<Partial<string>, Partial<string>> partialBuilder)
            => it.AddFieldName("removed", partialBuilder(new Partial<string>()));
        
        public static Partial<DiffDto> WithRemoveAll(this Partial<DiffDto> it)
            => it.AddFieldName("removeAll");
        
    }
    
}
