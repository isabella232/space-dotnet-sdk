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

namespace JetBrains.Space.Client.KBArticlePartialBuilder;

public static class KBArticlePartialExtensions
{
    public static Partial<KBArticle> WithId(this Partial<KBArticle> it)
        => it.AddFieldName("id");
    
    public static Partial<KBArticle> WithIsArchived(this Partial<KBArticle> it)
        => it.AddFieldName("archived");
    
    public static Partial<KBArticle> WithTitle(this Partial<KBArticle> it)
        => it.AddFieldName("title");
    
    public static Partial<KBArticle> WithBook(this Partial<KBArticle> it)
        => it.AddFieldName("book");
    
    public static Partial<KBArticle> WithBook(this Partial<KBArticle> it, Func<Partial<KBBook>, Partial<KBBook>> partialBuilder)
        => it.AddFieldName("book", partialBuilder(new Partial<KBBook>(it)));
    
    public static Partial<KBArticle> WithFolder(this Partial<KBArticle> it)
        => it.AddFieldName("folder");
    
    public static Partial<KBArticle> WithFolder(this Partial<KBArticle> it, Func<Partial<KBFolder>, Partial<KBFolder>> partialBuilder)
        => it.AddFieldName("folder", partialBuilder(new Partial<KBFolder>(it)));
    
    public static Partial<KBArticle> WithDocumentId(this Partial<KBArticle> it)
        => it.AddFieldName("documentId");
    
    public static Partial<KBArticle> WithDocument(this Partial<KBArticle> it)
        => it.AddFieldName("document");
    
    public static Partial<KBArticle> WithDocument(this Partial<KBArticle> it, Func<Partial<DocumentInContainer>, Partial<DocumentInContainer>> partialBuilder)
        => it.AddFieldName("document", partialBuilder(new Partial<DocumentInContainer>(it)));
    
    public static Partial<KBArticle> WithDocumentRef(this Partial<KBArticle> it)
        => it.AddFieldName("documentRef");
    
    public static Partial<KBArticle> WithDocumentRef(this Partial<KBArticle> it, Func<Partial<Document>, Partial<Document>> partialBuilder)
        => it.AddFieldName("documentRef", partialBuilder(new Partial<Document>(it)));
    
    public static Partial<KBArticle> WithCreated(this Partial<KBArticle> it)
        => it.AddFieldName("created");
    
    public static Partial<KBArticle> WithCreatedBy(this Partial<KBArticle> it)
        => it.AddFieldName("createdBy");
    
    public static Partial<KBArticle> WithCreatedBy(this Partial<KBArticle> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("createdBy", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<KBArticle> WithUpdated(this Partial<KBArticle> it)
        => it.AddFieldName("updated");
    
    public static Partial<KBArticle> WithUpdatedBy(this Partial<KBArticle> it)
        => it.AddFieldName("updatedBy");
    
    public static Partial<KBArticle> WithUpdatedBy(this Partial<KBArticle> it, Func<Partial<CPrincipal>, Partial<CPrincipal>> partialBuilder)
        => it.AddFieldName("updatedBy", partialBuilder(new Partial<CPrincipal>(it)));
    
    public static Partial<KBArticle> WithAlias(this Partial<KBArticle> it)
        => it.AddFieldName("alias");
    
}

