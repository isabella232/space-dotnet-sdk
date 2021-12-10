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

namespace JetBrains.Space.Client.PackageRepositoryConnectionSpacePartialBuilder;

public static class PackageRepositoryConnectionSpacePartialExtensions
{
    public static Partial<PackageRepositoryConnectionSpace> WithId(this Partial<PackageRepositoryConnectionSpace> it)
        => it.AddFieldName("id");
    
    public static Partial<PackageRepositoryConnectionSpace> WithIsEnableCaching(this Partial<PackageRepositoryConnectionSpace> it)
        => it.AddFieldName("enableCaching");
    
    public static Partial<PackageRepositoryConnectionSpace> WithIsStickyPackages(this Partial<PackageRepositoryConnectionSpace> it)
        => it.AddFieldName("stickyPackages");
    
    public static Partial<PackageRepositoryConnectionSpace> WithPackageNameFilters(this Partial<PackageRepositoryConnectionSpace> it)
        => it.AddFieldName("packageNameFilters");
    
    public static Partial<PackageRepositoryConnectionSpace> WithRepository(this Partial<PackageRepositoryConnectionSpace> it)
        => it.AddFieldName("repository");
    
    public static Partial<PackageRepositoryConnectionSpace> WithRepository(this Partial<PackageRepositoryConnectionSpace> it, Func<Partial<ProjectPackageRepository>, Partial<ProjectPackageRepository>> partialBuilder)
        => it.AddFieldName("repository", partialBuilder(new Partial<ProjectPackageRepository>(it)));
    
}

