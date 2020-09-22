// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
// 
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

#nullable enable
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

namespace SpaceDotNet.Client.KBBookPartialBuilder
{
    public static class KBBookPartialExtensions
    {
        public static Partial<KBBook> WithId(this Partial<KBBook> it)
            => it.AddFieldName("id");
        
        public static Partial<KBBook> WithIsArchived(this Partial<KBBook> it)
            => it.AddFieldName("archived");
        
        public static Partial<KBBook> WithName(this Partial<KBBook> it)
            => it.AddFieldName("name");
        
        public static Partial<KBBook> WithSummary(this Partial<KBBook> it)
            => it.AddFieldName("summary");
        
        public static Partial<KBBook> WithUpdated(this Partial<KBBook> it)
            => it.AddFieldName("updated");
        
        public static Partial<KBBook> WithAlias(this Partial<KBBook> it)
            => it.AddFieldName("alias");
        
        public static Partial<KBBook> WithContexts(this Partial<KBBook> it)
            => it.AddFieldName("contexts");
        
        public static Partial<KBBook> WithContexts(this Partial<KBBook> it, Func<Partial<KBBookContext>, Partial<KBBookContext>> partialBuilder)
            => it.AddFieldName("contexts", partialBuilder(new Partial<KBBookContext>(it)));
        
        public static Partial<KBBook> WithLocations(this Partial<KBBook> it)
            => it.AddFieldName("locations");
        
        public static Partial<KBBook> WithLocations(this Partial<KBBook> it, Func<Partial<TDLocation>, Partial<TDLocation>> partialBuilder)
            => it.AddFieldName("locations", partialBuilder(new Partial<TDLocation>(it)));
        
        public static Partial<KBBook> WithRootFolder(this Partial<KBBook> it)
            => it.AddFieldName("rootFolder");
        
        public static Partial<KBBook> WithRootFolder(this Partial<KBBook> it, Func<Partial<KBFolder>, Partial<KBFolder>> partialBuilder)
            => it.AddFieldName("rootFolder", partialBuilder(new Partial<KBFolder>(it)));
        
        public static Partial<KBBook> WithTeams(this Partial<KBBook> it)
            => it.AddFieldName("teams");
        
        public static Partial<KBBook> WithTeams(this Partial<KBBook> it, Func<Partial<TDTeam>, Partial<TDTeam>> partialBuilder)
            => it.AddFieldName("teams", partialBuilder(new Partial<TDTeam>(it)));
        
    }
    
}
