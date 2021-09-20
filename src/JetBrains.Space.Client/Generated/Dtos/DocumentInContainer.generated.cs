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

namespace JetBrains.Space.Client
{
    public sealed class DocumentInContainer
         : IPropagatePropertyAccessPath
    {
        public DocumentInContainer() { }
        
        public DocumentInContainer(string id, bool archived, string containerLinkId, string title, DateTime modified, bool shared, DocumentContainerInfo containerInfo, DocumentBodyType bodyType, bool deleted, int accessOrdinal, DocumentBody documentBody, TDMemberProfile? author = null, CPrincipal? createdBy = null, DateTime? created = null, CPrincipal? modifiedBy = null, PublicationDetails? publicationDetails2 = null, DocumentFolder? folderRef = null, CPrincipal? archivedBy = null, DateTime? archivedAt = null, bool? published = null)
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
            PublicationDetails2 = publicationDetails2;
            FolderRef = folderRef;
            ContainerInfo = containerInfo;
            BodyType = bodyType;
            IsDeleted = deleted;
            ArchivedBy = archivedBy;
            ArchivedAt = archivedAt;
            IsPublished = published;
            AccessOrdinal = accessOrdinal;
            DocumentBody = documentBody;
        }
        
        private PropertyValue<string> _id = new PropertyValue<string>(nameof(DocumentInContainer), nameof(Id));
        
        [Required]
        [JsonPropertyName("id")]
        public string Id
        {
            get => _id.GetValue();
            set => _id.SetValue(value);
        }
    
        private PropertyValue<bool> _archived = new PropertyValue<bool>(nameof(DocumentInContainer), nameof(IsArchived));
        
        [Required]
        [JsonPropertyName("archived")]
        public bool IsArchived
        {
            get => _archived.GetValue();
            set => _archived.SetValue(value);
        }
    
        private PropertyValue<string> _containerLinkId = new PropertyValue<string>(nameof(DocumentInContainer), nameof(ContainerLinkId));
        
        [Required]
        [JsonPropertyName("containerLinkId")]
        public string ContainerLinkId
        {
            get => _containerLinkId.GetValue();
            set => _containerLinkId.SetValue(value);
        }
    
        private PropertyValue<string> _title = new PropertyValue<string>(nameof(DocumentInContainer), nameof(Title));
        
        [Required]
        [JsonPropertyName("title")]
        public string Title
        {
            get => _title.GetValue();
            set => _title.SetValue(value);
        }
    
        private PropertyValue<TDMemberProfile?> _author = new PropertyValue<TDMemberProfile?>(nameof(DocumentInContainer), nameof(Author));
        
        [JsonPropertyName("author")]
        public TDMemberProfile? Author
        {
            get => _author.GetValue();
            set => _author.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _createdBy = new PropertyValue<CPrincipal?>(nameof(DocumentInContainer), nameof(CreatedBy));
        
        [JsonPropertyName("createdBy")]
        public CPrincipal? CreatedBy
        {
            get => _createdBy.GetValue();
            set => _createdBy.SetValue(value);
        }
    
        private PropertyValue<DateTime> _modified = new PropertyValue<DateTime>(nameof(DocumentInContainer), nameof(Modified));
        
        [Required]
        [JsonPropertyName("modified")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime Modified
        {
            get => _modified.GetValue();
            set => _modified.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _created = new PropertyValue<DateTime?>(nameof(DocumentInContainer), nameof(Created));
        
        [JsonPropertyName("created")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? Created
        {
            get => _created.GetValue();
            set => _created.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _modifiedBy = new PropertyValue<CPrincipal?>(nameof(DocumentInContainer), nameof(ModifiedBy));
        
        [JsonPropertyName("modifiedBy")]
        public CPrincipal? ModifiedBy
        {
            get => _modifiedBy.GetValue();
            set => _modifiedBy.SetValue(value);
        }
    
        private PropertyValue<bool> _shared = new PropertyValue<bool>(nameof(DocumentInContainer), nameof(IsShared));
        
        [Required]
        [JsonPropertyName("shared")]
        public bool IsShared
        {
            get => _shared.GetValue();
            set => _shared.SetValue(value);
        }
    
        private PropertyValue<PublicationDetails?> _publicationDetails2 = new PropertyValue<PublicationDetails?>(nameof(DocumentInContainer), nameof(PublicationDetails2));
        
        [JsonPropertyName("publicationDetails2")]
        public PublicationDetails? PublicationDetails2
        {
            get => _publicationDetails2.GetValue();
            set => _publicationDetails2.SetValue(value);
        }
    
        private PropertyValue<DocumentFolder?> _folderRef = new PropertyValue<DocumentFolder?>(nameof(DocumentInContainer), nameof(FolderRef));
        
        [JsonPropertyName("folderRef")]
        public DocumentFolder? FolderRef
        {
            get => _folderRef.GetValue();
            set => _folderRef.SetValue(value);
        }
    
        private PropertyValue<DocumentContainerInfo> _containerInfo = new PropertyValue<DocumentContainerInfo>(nameof(DocumentInContainer), nameof(ContainerInfo));
        
        [Required]
        [JsonPropertyName("containerInfo")]
        public DocumentContainerInfo ContainerInfo
        {
            get => _containerInfo.GetValue();
            set => _containerInfo.SetValue(value);
        }
    
        private PropertyValue<DocumentBodyType> _bodyType = new PropertyValue<DocumentBodyType>(nameof(DocumentInContainer), nameof(BodyType));
        
        [Required]
        [JsonPropertyName("bodyType")]
        public DocumentBodyType BodyType
        {
            get => _bodyType.GetValue();
            set => _bodyType.SetValue(value);
        }
    
        private PropertyValue<bool> _deleted = new PropertyValue<bool>(nameof(DocumentInContainer), nameof(IsDeleted));
        
        [Required]
        [JsonPropertyName("deleted")]
        public bool IsDeleted
        {
            get => _deleted.GetValue();
            set => _deleted.SetValue(value);
        }
    
        private PropertyValue<CPrincipal?> _archivedBy = new PropertyValue<CPrincipal?>(nameof(DocumentInContainer), nameof(ArchivedBy));
        
        [JsonPropertyName("archivedBy")]
        public CPrincipal? ArchivedBy
        {
            get => _archivedBy.GetValue();
            set => _archivedBy.SetValue(value);
        }
    
        private PropertyValue<DateTime?> _archivedAt = new PropertyValue<DateTime?>(nameof(DocumentInContainer), nameof(ArchivedAt));
        
        [JsonPropertyName("archivedAt")]
        [JsonConverter(typeof(SpaceDateTimeConverter))]
        public DateTime? ArchivedAt
        {
            get => _archivedAt.GetValue();
            set => _archivedAt.SetValue(value);
        }
    
        private PropertyValue<bool?> _published = new PropertyValue<bool?>(nameof(DocumentInContainer), nameof(IsPublished));
        
        [JsonPropertyName("published")]
        public bool? IsPublished
        {
            get => _published.GetValue();
            set => _published.SetValue(value);
        }
    
        private PropertyValue<int> _accessOrdinal = new PropertyValue<int>(nameof(DocumentInContainer), nameof(AccessOrdinal));
        
        [Required]
        [JsonPropertyName("accessOrdinal")]
        public int AccessOrdinal
        {
            get => _accessOrdinal.GetValue();
            set => _accessOrdinal.SetValue(value);
        }
    
        private PropertyValue<DocumentBody> _documentBody = new PropertyValue<DocumentBody>(nameof(DocumentInContainer), nameof(DocumentBody));
        
        [Required]
        [JsonPropertyName("documentBody")]
        public DocumentBody DocumentBody
        {
            get => _documentBody.GetValue();
            set => _documentBody.SetValue(value);
        }
    
        public  void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _id.SetAccessPath(path, validateHasBeenSet);
            _archived.SetAccessPath(path, validateHasBeenSet);
            _containerLinkId.SetAccessPath(path, validateHasBeenSet);
            _title.SetAccessPath(path, validateHasBeenSet);
            _author.SetAccessPath(path, validateHasBeenSet);
            _createdBy.SetAccessPath(path, validateHasBeenSet);
            _modified.SetAccessPath(path, validateHasBeenSet);
            _created.SetAccessPath(path, validateHasBeenSet);
            _modifiedBy.SetAccessPath(path, validateHasBeenSet);
            _shared.SetAccessPath(path, validateHasBeenSet);
            _publicationDetails2.SetAccessPath(path, validateHasBeenSet);
            _folderRef.SetAccessPath(path, validateHasBeenSet);
            _containerInfo.SetAccessPath(path, validateHasBeenSet);
            _bodyType.SetAccessPath(path, validateHasBeenSet);
            _deleted.SetAccessPath(path, validateHasBeenSet);
            _archivedBy.SetAccessPath(path, validateHasBeenSet);
            _archivedAt.SetAccessPath(path, validateHasBeenSet);
            _published.SetAccessPath(path, validateHasBeenSet);
            _accessOrdinal.SetAccessPath(path, validateHasBeenSet);
            _documentBody.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
