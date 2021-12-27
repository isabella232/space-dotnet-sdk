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
#pragma warning disable 618

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Space.Common;
using JetBrains.Space.Common.Json.Serialization;
using JetBrains.Space.Common.Json.Serialization.Polymorphism;
using JetBrains.Space.Common.Types;

namespace JetBrains.Space.Client.PackagesPublishingPartialBuilder;

public static class PackagesPublishingPartialExtensions
{
    public static Partial<PackagesPublishing> WithPublishingId(this Partial<PackagesPublishing> it)
        => it.AddFieldName("publishingId");
    
    public static Partial<PackagesPublishing> WithSource(this Partial<PackagesPublishing> it)
        => it.AddFieldName("source");
    
    public static Partial<PackagesPublishing> WithSource(this Partial<PackagesPublishing> it, Func<Partial<PublishingSource>, Partial<PublishingSource>> partialBuilder)
        => it.AddFieldName("source", partialBuilder(new Partial<PublishingSource>(it)));
    
    public static Partial<PackagesPublishing> WithCreated(this Partial<PackagesPublishing> it)
        => it.AddFieldName("created");
    
    public static Partial<PackagesPublishing> WithStarted(this Partial<PackagesPublishing> it)
        => it.AddFieldName("started");
    
    public static Partial<PackagesPublishing> WithCompleted(this Partial<PackagesPublishing> it)
        => it.AddFieldName("completed");
    
    public static Partial<PackagesPublishing> WithIsSuccessful(this Partial<PackagesPublishing> it)
        => it.AddFieldName("successful");
    
    public static Partial<PackagesPublishing> WithError(this Partial<PackagesPublishing> it)
        => it.AddFieldName("error");
    
    public static Partial<PackagesPublishing> WithPrincipal(this Partial<PackagesPublishing> it)
        => it.AddFieldName("principal");
    
    public static Partial<PackagesPublishing> WithPrincipal(this Partial<PackagesPublishing> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("principal", partialBuilder(new Partial<CPrincipal>(it)));
    
}

