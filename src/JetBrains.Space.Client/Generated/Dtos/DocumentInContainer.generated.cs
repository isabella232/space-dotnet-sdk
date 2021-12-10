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

public sealed class DocumentInContainer
     : IPropagatePropertyAccessPath
{
    public DocumentInContainer() { }
    
    public DocumentInContainer(string id, bool archived, string containerLinkId, string title, DateTime modified, bool shared, bool deleted, int accessOrdinal, DocumentBodyInfo documentBody, TDMemberProfile? author = null, CPrincipal? createdBy = null, DateTime? created = null, CPrincipal? modifiedBy = null, PublicationDetails? publicationDetails = null, PublicationDetails? publicationDetails2 = null, DocumentFolder? folderRef = null, DocumentContainerInfo? containerInfo = null, DocumentBodyType? bodyType = null, DocumentBodyInfo? bodyInfo = null, CPrincipal? archivedBy = null, DateTime? archivedAt = null)
    {
        Id = id;
        IsArchived = archived;
        ContainerLinkId = containerLinkId;
        Title = title;
        Author = author;
        CreatedBy = createdBy;
        Modified = modified;
        Created = created;
        ModifiedBy = modifiedBy;
        IsShared = shared;
        PublicationDetails = publicationDetails;
        PublicationDetails2 = publicationDetails2;
        FolderRef = folderRef;
        ContainerInfo = containerInfo;
        BodyType = bodyType;
        BodyInfo = bodyInfo;
        IsDeleted = deleted;
        ArchivedBy = archivedBy;
        ArchivedAt = archivedAt;
        AccessOrdinal = accessOrdinal;
        DocumentBody = documentBody;
    }
    
    private PropertyValue<string> _id = new PropertyValue<string>(nameof(DocumentInContainer), nameof(Id), "id");
    
    [Required]
    [JsonPropertyName("id")]
    public string Id
    {
        get => _id.GetValue(InlineErrors);
        set => _id.SetValue(value);
    }

    private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(DocumentInContainer), nameof(IsArchived), "archived");
    
    [Required]
    [JsonPropertyName("archived")]
    public bool IsArchived
    {
        get => _archived.GetValue(InlineErrors);
        set => _archived.SetValue(value);
    }

    private PropertyValue<string> _containerLinkId = new PropertyValue<string>(nameof(DocumentInContainer), nameof(ContainerLinkId), "containerLinkId");
    
    [Required]
    [JsonPropertyName("containerLinkId")]
    public string ContainerLinkId
    {
        get => _containerLinkId.GetValue(InlineErrors);
        set => _containerLinkId.SetValue(value);
    }

    private PropertyValue<string> _title = new PropertyValue<string>(nameof(DocumentInContainer), nameof(Title), "title");
    
    [Required]
    [JsonPropertyName("title")]
    public string Title
    {
        get => _title.GetValue(InlineErrors);
        set => _title.SetValue(value);
    }

    private PropertyValue<TDMemberProfile?> _author = new PropertyValue<TDMemberProfile?>(nameof(DocumentInContainer), nameof(Author), "author");
    
    [JsonPropertyName("author")]
    public TDMemberProfile? Author
    {
        get => _author.GetValue(InlineErrors);
        set => _author.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _createdBy = new PropertyValue<CPrincipal?>(nameof(DocumentInContainer), nameof(CreatedBy), "createdBy");
    
    [JsonPropertyName("createdBy")]
    public CPrincipal? CreatedBy
    {
        get => _createdBy.GetValue(InlineErrors);
        set => _createdBy.SetValue(value);
    }

    private PropertyValue<DateTime> _modified = new PropertyValue<DateTime>(nameof(DocumentInContainer), nameof(Modified), "modified");
    
    [Required]
    [JsonPropertyName("modified")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime Modified
    {
        get => _modified.GetValue(InlineErrors);
        set => _modified.SetValue(value);
    }

    private PropertyValue<DateTime?> _created = new PropertyValue<DateTime?>(nameof(DocumentInContainer), nameof(Created), "created");
    
    [JsonPropertyName("created")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? Created
    {
        get => _created.GetValue(InlineErrors);
        set => _created.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _modifiedBy = new PropertyValue<CPrincipal?>(nameof(DocumentInContainer), nameof(ModifiedBy), "modifiedBy");
    
    [JsonPropertyName("modifiedBy")]
    public CPrincipal? ModifiedBy
    {
        get => _modifiedBy.GetValue(InlineErrors);
        set => _modifiedBy.SetValue(value);
    }

    private PropertyValue<bool> _shared = new PropertyValue<bool>(nameof(DocumentInContainer), nameof(IsShared), "shared");
    
    [Required]
    [JsonPropertyName("shared")]
    public bool IsShared
    {
        get => _shared.GetValue(InlineErrors);
        set => _shared.SetValue(value);
    }

    private PropertyValue<PublicationDetails?> _publicationDetails = new PropertyValue<PublicationDetails?>(nameof(DocumentInContainer), nameof(PublicationDetails), "publicationDetails");
    
    [JsonPropertyName("publicationDetails")]
    public PublicationDetails? PublicationDetails
    {
        get => _publicationDetails.GetValue(InlineErrors);
        set => _publicationDetails.SetValue(value);
    }

    private PropertyValue<PublicationDetails?> _publicationDetails2 = new PropertyValue<PublicationDetails?>(nameof(DocumentInContainer), nameof(PublicationDetails2), "publicationDetails2");
    
    [JsonPropertyName("publicationDetails2")]
    public PublicationDetails? PublicationDetails2
    {
        get => _publicationDetails2.GetValue(InlineErrors);
        set => _publicationDetails2.SetValue(value);
    }

    private PropertyValue<DocumentFolder?> _folderRef = new PropertyValue<DocumentFolder?>(nameof(DocumentInContainer), nameof(FolderRef), "folderRef");
    
    [JsonPropertyName("folderRef")]
    public DocumentFolder? FolderRef
    {
        get => _folderRef.GetValue(InlineErrors);
        set => _folderRef.SetValue(value);
    }

    private PropertyValue<DocumentContainerInfo?> _containerInfo = new PropertyValue<DocumentContainerInfo?>(nameof(DocumentInContainer), nameof(ContainerInfo), "containerInfo");
    
    [JsonPropertyName("containerInfo")]
    public DocumentContainerInfo? ContainerInfo
    {
        get => _containerInfo.GetValue(InlineErrors);
        set => _containerInfo.SetValue(value);
    }

    private PropertyValue<DocumentBodyType?> _bodyType = new PropertyValue<DocumentBodyType?>(nameof(DocumentInContainer), nameof(BodyType), "bodyType");
    
    [JsonPropertyName("bodyType")]
    public DocumentBodyType? BodyType
    {
        get => _bodyType.GetValue(InlineErrors);
        set => _bodyType.SetValue(value);
    }

    private PropertyValue<DocumentBodyInfo?> _bodyInfo = new PropertyValue<DocumentBodyInfo?>(nameof(DocumentInContainer), nameof(BodyInfo), "bodyInfo");
    
    [JsonPropertyName("bodyInfo")]
    public DocumentBodyInfo? BodyInfo
    {
        get => _bodyInfo.GetValue(InlineErrors);
        set => _bodyInfo.SetValue(value);
    }

    private PropertyValue<bool> _deleted = new PropertyValue<bool>(nameof(DocumentInContainer), nameof(IsDeleted), "deleted");
    
    [Required]
    [JsonPropertyName("deleted")]
    public bool IsDeleted
    {
        get => _deleted.GetValue(InlineErrors);
        set => _deleted.SetValue(value);
    }

    private PropertyValue<CPrincipal?> _archivedBy = new PropertyValue<CPrincipal?>(nameof(DocumentInContainer), nameof(ArchivedBy), "archivedBy");
    
    [JsonPropertyName("archivedBy")]
    public CPrincipal? ArchivedBy
    {
        get => _archivedBy.GetValue(InlineErrors);
        set => _archivedBy.SetValue(value);
    }

    private PropertyValue<DateTime?> _archivedAt = new PropertyValue<DateTime?>(nameof(DocumentInContainer), nameof(ArchivedAt), "archivedAt");
    
    [JsonPropertyName("archivedAt")]
    [JsonConverter(typeof(SpaceDateTimeConverter))]
    public DateTime? ArchivedAt
    {
        get => _archivedAt.GetValue(InlineErrors);
        set => _archivedAt.SetValue(value);
    }

    private PropertyValue<int> _accessOrdinal = new PropertyValue<int>(nameof(DocumentInContainer), nameof(AccessOrdinal), "accessOrdinal");
    
    [Required]
    [JsonPropertyName("accessOrdinal")]
    public int AccessOrdinal
    {
        get => _accessOrdinal.GetValue(InlineErrors);
        set => _accessOrdinal.SetValue(value);
    }

    private PropertyValue<DocumentBodyInfo> _documentBody = new PropertyValue<DocumentBodyInfo>(nameof(DocumentInContainer), nameof(DocumentBody), "documentBody");
    
    [Required]
    [JsonPropertyName("documentBody")]
    public DocumentBodyInfo DocumentBody
    {
        get => _documentBody.GetValue(InlineErrors);
        set => _documentBody.SetValue(value);
    }

    public  void SetAccessPath(string parentChainPath, bool validateHasBeenSet)
    {
        _id.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archived.SetAccessPath(parentChainPath, validateHasBeenSet);
        _containerLinkId.SetAccessPath(parentChainPath, validateHasBeenSet);
        _title.SetAccessPath(parentChainPath, validateHasBeenSet);
        _author.SetAccessPath(parentChainPath, validateHasBeenSet);
        _createdBy.SetAccessPath(parentChainPath, validateHasBeenSet);
        _modified.SetAccessPath(parentChainPath, validateHasBeenSet);
        _created.SetAccessPath(parentChainPath, validateHasBeenSet);
        _modifiedBy.SetAccessPath(parentChainPath, validateHasBeenSet);
        _shared.SetAccessPath(parentChainPath, validateHasBeenSet);
        _publicationDetails.SetAccessPath(parentChainPath, validateHasBeenSet);
        _publicationDetails2.SetAccessPath(parentChainPath, validateHasBeenSet);
        _folderRef.SetAccessPath(parentChainPath, validateHasBeenSet);
        _containerInfo.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bodyType.SetAccessPath(parentChainPath, validateHasBeenSet);
        _bodyInfo.SetAccessPath(parentChainPath, validateHasBeenSet);
        _deleted.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archivedBy.SetAccessPath(parentChainPath, validateHasBeenSet);
        _archivedAt.SetAccessPath(parentChainPath, validateHasBeenSet);
        _accessOrdinal.SetAccessPath(parentChainPath, validateHasBeenSet);
        _documentBody.SetAccessPath(parentChainPath, validateHasBeenSet);
    }
    
    /// <inheritdoc />
    [JsonPropertyName("$errors")]
    public List<ApiInlineError> InlineErrors { get; set; } = new();

}

