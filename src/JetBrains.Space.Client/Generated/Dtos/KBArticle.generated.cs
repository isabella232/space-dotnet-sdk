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

namespace JetBrains.Space.Client;

public sealed class KBArticle
     : IPropagatePropertyAccessPath
{
    public KBArticle() { }
    
    public KBArticle(string id, bool archived, string title, KBBook book, KBFolder folder, string documentId, Document documentRef, DateTime created, DateTime updated, string alias, DocumentInContainer? document = null, CPrincipal? createdBy = null, CPrincipal? updatedBy = null)
    {
        Id = id;
        IsArchived = archived;
        Title = title;
        Book = book;
        Folder = folder;
        DocumentId = documentId;
        Document = document;
        DocumentRef = documentRef;
        Created = created;
        CreatedBy = createdBy;
        Updated = updated;
        UpdatedBy = updatedBy;
        Alias = alias;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(KBArticle), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(KBArticle), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<string> _title = new PropertyValue<string>(nameof(KBArticle), nameof(Title), "title");
    
    [Required]
    [JsonPropertyName("title")]
    public string Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<KBBook> _book = new PropertyValue<KBBook>(nameof(KBArticle), nameof(Book), "book");
    
    [Required]
    [JsonPropertyName("book")]
    public KBBook Book
    {
        get => _book.GetValue(InlineErrors);
        set => _book.SetValue(value);
    }

    private PropertyValue<KBFolder> _folder = new PropertyValue<KBFolder>(nameof(KBArticle), nameof(Folder), "folder");
    
    [Required]
    [JsonPropertyName("folder")]
    public KBFolder Folder
    {
        get => _folder.GetValue(InlineErrors);
        set => _folder.SetValue(value);
    }

    private PropertyValue<string> _documentId = new PropertyValue<string>(nameof(KBArticle), nameof(DocumentId), "documentId");
    
    [Required]
    [JsonPropertyName("documentId")]
    public string DocumentId
    {
        get => _documentId.GetValue(InlineErrors);
        set => _documentId.SetValue(value);
    }

    private PropertyValue<DocumentInContainer?> _document = new PropertyValue<DocumentInContainer?>(nameof(KBArticle), nameof(Document), "document");
    
    [JsonPropertyName("document")]
    public DocumentInContainer? Document
    {
        get => _document.GetValue(InlineErrors);
        set => _document.SetValue(value);
    }

    private PropertyValue<Document> _documentRef = new PropertyValue<Document>(nameof(KBArticle), nameof(DocumentRef), "documentRef");
    
    [Required]
    [JsonPropertyName("documentRef")]
    public Document DocumentRef
    {
        get => _documentRef.GetValue(InlineErrors);
        set => _documentRef.SetValue(value);
    }

    private PropertyValue<DateTime> _created = new PropertyValue<DateTime>(nameof(KBArticle), nameof(Created), "created");
    
    [Required]
    [JsonPropertyName("created")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Created
    {
        get => _created.GetValue(InlineErrors);
        set => _created.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _createdBy = new PropertyValue<CPrincipal?>(nameof(KBArticle), nameof(CreatedBy), "createdBy");
    
    [JsonPropertyName("createdBy")]
    public CPrincipal? CreatedBy
    {
        get => _createdBy.GetValue(InlineErrors);
        set => _createdBy.SetValue(value);
    }

    private PropertyValue<DateTime> _updated = new PropertyValue<DateTime>(nameof(KBArticle), nameof(Updated), "updated");
    
    [Required]
    [JsonPropertyName("updated")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Updated
    {
        get => _updated.GetValue(InlineErrors);
        set => _updated.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _updatedBy = new PropertyValue<CPrincipal?>(nameof(KBArticle), nameof(UpdatedBy), "updatedBy");
    
    [JsonPropertyName("updatedBy")]
    public CPrincipal? UpdatedBy
    {
        get => _updatedBy.GetValue(InlineErrors);
        set => _updatedBy.SetValue(value);
    }

    private PropertyValue<string> _alias = new PropertyValue<string>(nameof(KBArticle), nameof(Alias), "alias");
    
    [Required]
    [JsonPropertyName("alias")]
    public string Alias
    {
        get => _alias.GetValue(InlineErrors);
        set => _alias.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _book.SetAccessPath(parentChainPath, validateHasBeenSet);
        _folder.SetAccessPath(parentChainPath, validateHasBeenSet);
        _documentId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _document.SetAccessPath(parentChainPath, validateHasBeenSet);
        _documentRef.SetAccessPath(parentChainPath, validateHasBeenSet);
        _created.SetAccessPath(parentChainPath, validateHasBeenSet);
        _createdBy.SetAccessPath(parentChainPath, validateHasBeenSet);
        _updated.SetAccessPath(parentChainPath, validateHasBeenSet);
        _updatedBy.SetAccessPath(parentChainPath, validateHasBeenSet);
        _alias.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

