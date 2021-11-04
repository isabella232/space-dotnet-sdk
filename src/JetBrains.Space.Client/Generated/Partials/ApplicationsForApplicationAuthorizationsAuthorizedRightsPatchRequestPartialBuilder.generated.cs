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

namespace JetBrains.Space.Client.ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequestPartialBuilder;

public static class ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequestPartialExtensions
{
    public static Partial<ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequest> WithContextIdentifier(this Partial<ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequest> it)
        => it.AddFieldName("contextIdentifier");
    
    public static Partial<ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequest> WithContextIdentifier(this Partial<ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequest> it, Func<Partial<PermissionContextIdentifier>, Partial<PermissionContextIdentifier>> partialBuilder)
        => it.AddFieldName("contextIdentifier", partialBuilder(new Partial<PermissionContextIdentifier>(it)));
    
    public static Partial<ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequest> WithUpdates(this Partial<ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequest> it)
        => it.AddFieldName("updates");
    
    public static Partial<ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequest> WithUpdates(this Partial<ApplicationsForApplicationAuthorizationsAuthorizedRightsPatchRequest> it, Func<Partial<RightUpdateDTO>, Partial<RightUpdateDTO>> partialBuilder)
        => it.AddFieldName("updates", partialBuilder(new Partial<RightUpdateDTO>(it)));
    
}

