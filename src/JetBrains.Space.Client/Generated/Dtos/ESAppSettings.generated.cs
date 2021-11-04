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

public sealed class ESAppSettings
     : IPropagatePropertyAccessPath
{
    public ESAppSettings() { }
    
    public ESAppSettings(EndpointDTO endpoint, EndpointAuthDTO endpointAuth, bool? clientCredentialsFlowEnabled = null, bool? codeFlowEnabled = null, string? codeFlowRedirectURIs = null, bool? pkceRequired = null, bool? implicitFlowEnabled = null, string? implicitFlowRedirectURIs = null)
    {
        IsClientCredentialsFlowEnabled = clientCredentialsFlowEnabled;
        IsCodeFlowEnabled = codeFlowEnabled;
        CodeFlowRedirectURIs = codeFlowRedirectURIs;
        IsPkceRequired = pkceRequired;
        IsImplicitFlowEnabled = implicitFlowEnabled;
        ImplicitFlowRedirectURIs = implicitFlowRedirectURIs;
        Endpoint = endpoint;
        EndpointAuth = endpointAuth;
    }
    
    private PropertyValue<bool?> _clientCredentialsFlowEnabled = new PropertyValue<bool?>(nameof(ESAppSettings), nameof(IsClientCredentialsFlowEnabled));
    
    [JsonPropertyName("clientCredentialsFlowEnabled")]
    public bool? IsClientCredentialsFlowEnabled
    {
        get => _clientCredentialsFlowEnabled.GetValue();
        set => _clientCredentialsFlowEnabled.SetValue(value);
    }

    private PropertyValue<bool?> _codeFlowEnabled = new PropertyValue<bool?>(nameof(ESAppSettings), nameof(IsCodeFlowEnabled));
    
    [JsonPropertyName("codeFlowEnabled")]
    public bool? IsCodeFlowEnabled
    {
        get => _codeFlowEnabled.GetValue();
        set => _codeFlowEnabled.SetValue(value);
    }

    private PropertyValue<string?> _codeFlowRedirectURIs = new PropertyValue<string?>(nameof(ESAppSettings), nameof(CodeFlowRedirectURIs));
    
    [JsonPropertyName("codeFlowRedirectURIs")]
    public string? CodeFlowRedirectURIs
    {
        get => _codeFlowRedirectURIs.GetValue();
        set => _codeFlowRedirectURIs.SetValue(value);
    }

    private PropertyValue<bool?> _pkceRequired = new PropertyValue<bool?>(nameof(ESAppSettings), nameof(IsPkceRequired));
    
    [JsonPropertyName("pkceRequired")]
    public bool? IsPkceRequired
    {
        get => _pkceRequired.GetValue();
        set => _pkceRequired.SetValue(value);
    }

    private PropertyValue<bool?> _implicitFlowEnabled = new PropertyValue<bool?>(nameof(ESAppSettings), nameof(IsImplicitFlowEnabled));
    
    [JsonPropertyName("implicitFlowEnabled")]
    public bool? IsImplicitFlowEnabled
    {
        get => _implicitFlowEnabled.GetValue();
        set => _implicitFlowEnabled.SetValue(value);
    }

    private PropertyValue<string?> _implicitFlowRedirectURIs = new PropertyValue<string?>(nameof(ESAppSettings), nameof(ImplicitFlowRedirectURIs));
    
    [JsonPropertyName("implicitFlowRedirectURIs")]
    public string? ImplicitFlowRedirectURIs
    {
        get => _implicitFlowRedirectURIs.GetValue();
        set => _implicitFlowRedirectURIs.SetValue(value);
    }

    private PropertyValue<EndpointDTO> _endpoint = new PropertyValue<EndpointDTO>(nameof(ESAppSettings), nameof(Endpoint));
    
    [Required]
    [JsonPropertyName("endpoint")]
    public EndpointDTO Endpoint
    {
        get => _endpoint.GetValue();
        set => _endpoint.SetValue(value);
    }

    private PropertyValue<EndpointAuthDTO> _endpointAuth = new PropertyValue<EndpointAuthDTO>(nameof(ESAppSettings), nameof(EndpointAuth));
    
    [Required]
    [JsonPropertyName("endpointAuth")]
    public EndpointAuthDTO EndpointAuth
    {
        get => _endpointAuth.GetValue();
        set => _endpointAuth.SetValue(value);
    }

    public  void SetAccessPath(string path, bool validateHasBeenSet)
    {
        _clientCredentialsFlowEnabled.SetAccessPath(path, validateHasBeenSet);
        _codeFlowEnabled.SetAccessPath(path, validateHasBeenSet);
        _codeFlowRedirectURIs.SetAccessPath(path, validateHasBeenSet);
        _pkceRequired.SetAccessPath(path, validateHasBeenSet);
        _implicitFlowEnabled.SetAccessPath(path, validateHasBeenSet);
        _implicitFlowRedirectURIs.SetAccessPath(path, validateHasBeenSet);
        _endpoint.SetAccessPath(path, validateHasBeenSet);
        _endpointAuth.SetAccessPath(path, validateHasBeenSet);
    }

}

