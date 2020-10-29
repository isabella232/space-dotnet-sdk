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
    public sealed class ESSamlAuthModuleSettings
         : ESFederatedAuthModuleSettings, IClassNameConvertible, IPropagatePropertyAccessPath
    {
        [JsonPropertyName("className")]
        public override string? ClassName => "ES_SamlAuthModuleSettings";
        
        public ESSamlAuthModuleSettings() { }
        
        public ESSamlAuthModuleSettings(string idpUrl, string idpEntityId, string idpCertificateSHA256, string spEntityId, bool registerNewUsers, ESSamlAttributeNames attributeNames, SSLKeystore? sslKeystore = null, string? contactProfileId = null)
        {
            IdpUrl = idpUrl;
            IdpEntityId = idpEntityId;
            IdpCertificateSHA256 = idpCertificateSHA256;
            SpEntityId = spEntityId;
            SslKeystore = sslKeystore;
            IsRegisterNewUsers = registerNewUsers;
            ContactProfileId = contactProfileId;
            AttributeNames = attributeNames;
        }
        
        private PropertyValue<string> _idpUrl = new PropertyValue<string>(nameof(ESSamlAuthModuleSettings), nameof(IdpUrl));
        
        [Required]
        [JsonPropertyName("idpUrl")]
        public string IdpUrl
        {
            get => _idpUrl.GetValue();
            set => _idpUrl.SetValue(value);
        }
    
        private PropertyValue<string> _idpEntityId = new PropertyValue<string>(nameof(ESSamlAuthModuleSettings), nameof(IdpEntityId));
        
        [Required]
        [JsonPropertyName("idpEntityId")]
        public string IdpEntityId
        {
            get => _idpEntityId.GetValue();
            set => _idpEntityId.SetValue(value);
        }
    
        private PropertyValue<string> _idpCertificateSHA256 = new PropertyValue<string>(nameof(ESSamlAuthModuleSettings), nameof(IdpCertificateSHA256));
        
        [Required]
        [JsonPropertyName("idpCertificateSHA256")]
        public string IdpCertificateSHA256
        {
            get => _idpCertificateSHA256.GetValue();
            set => _idpCertificateSHA256.SetValue(value);
        }
    
        private PropertyValue<string> _spEntityId = new PropertyValue<string>(nameof(ESSamlAuthModuleSettings), nameof(SpEntityId));
        
        [Required]
        [JsonPropertyName("spEntityId")]
        public string SpEntityId
        {
            get => _spEntityId.GetValue();
            set => _spEntityId.SetValue(value);
        }
    
        private PropertyValue<SSLKeystore?> _sslKeystore = new PropertyValue<SSLKeystore?>(nameof(ESSamlAuthModuleSettings), nameof(SslKeystore));
        
        [JsonPropertyName("sslKeystore")]
        public SSLKeystore? SslKeystore
        {
            get => _sslKeystore.GetValue();
            set => _sslKeystore.SetValue(value);
        }
    
        private PropertyValue<bool> _registerNewUsers = new PropertyValue<bool>(nameof(ESSamlAuthModuleSettings), nameof(IsRegisterNewUsers));
        
        [Required]
        [JsonPropertyName("registerNewUsers")]
        public bool IsRegisterNewUsers
        {
            get => _registerNewUsers.GetValue();
            set => _registerNewUsers.SetValue(value);
        }
    
        private PropertyValue<string?> _contactProfileId = new PropertyValue<string?>(nameof(ESSamlAuthModuleSettings), nameof(ContactProfileId));
        
        [JsonPropertyName("contactProfileId")]
        public string? ContactProfileId
        {
            get => _contactProfileId.GetValue();
            set => _contactProfileId.SetValue(value);
        }
    
        private PropertyValue<ESSamlAttributeNames> _attributeNames = new PropertyValue<ESSamlAttributeNames>(nameof(ESSamlAuthModuleSettings), nameof(AttributeNames));
        
        [Required]
        [JsonPropertyName("attributeNames")]
        public ESSamlAttributeNames AttributeNames
        {
            get => _attributeNames.GetValue();
            set => _attributeNames.SetValue(value);
        }
    
        public override void SetAccessPath(string path, bool validateHasBeenSet)
        {
            _idpUrl.SetAccessPath(path, validateHasBeenSet);
            _idpEntityId.SetAccessPath(path, validateHasBeenSet);
            _idpCertificateSHA256.SetAccessPath(path, validateHasBeenSet);
            _spEntityId.SetAccessPath(path, validateHasBeenSet);
            _sslKeystore.SetAccessPath(path, validateHasBeenSet);
            _registerNewUsers.SetAccessPath(path, validateHasBeenSet);
            _contactProfileId.SetAccessPath(path, validateHasBeenSet);
            _attributeNames.SetAccessPath(path, validateHasBeenSet);
        }
    
    }
    
}
