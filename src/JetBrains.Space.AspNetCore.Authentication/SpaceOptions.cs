using System;
using System.Linq;
using System.Security.Claims;
using System.Text.Json;
using JetBrains.Annotations;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.OAuth;
using Microsoft.AspNetCore.Http;

namespace JetBrains.Space.AspNetCore.Authentication;

/// <summary>
/// Configuration options for <see cref="SpaceHandler"/>.
/// </summary>
[PublicAPI]
public class SpaceOptions : OAuthOptions
{
    private Uri? _serverUrl;

    /// <summary>
    /// Initializes a new <see cref="SpaceOptions"/>.
    /// </summary>
    public SpaceOptions()
    {
        CallbackPath = new PathString("/signin-space");
            
        AuthorizationEndpoint = SpaceDefaults.AuthorizationEndpointPath;
        TokenEndpoint = SpaceDefaults.TokenEndpointPath;
        UserInformationEndpoint = SpaceDefaults.UserInformationEndpointPath;
            
        ClaimActions.MapJsonKey(ClaimTypes.NameIdentifier, "id");
        ClaimActions.MapJsonKey(SpaceClaimTypes.UserId, "id");
        ClaimActions.MapJsonKey(SpaceClaimTypes.UserName, "username");
        ClaimActions.MapJsonKey(SpaceClaimTypes.SmallAvatar, "smallAvatar");
        ClaimActions.MapJsonKey(SpaceClaimTypes.Avatar, "avatar");
        ClaimActions.MapJsonKey(SpaceClaimTypes.ProfilePicture, "profilePicture");
        ClaimActions.MapJsonSubKey(SpaceClaimTypes.FirstName, "name", "firstName");
        ClaimActions.MapJsonSubKey(SpaceClaimTypes.LastName, "name", "lastName");
        ClaimActions.MapCustomJson(ClaimTypes.Name, element =>
        {
            if (element.TryGetProperty("name", out var nameElement) && nameElement.ValueKind == JsonValueKind.Object)
            {
                return nameElement.TryGetProperty("firstName", out var firstName) &&
                       nameElement.TryGetProperty("lastName", out var lastName)
                    ? $"{firstName} {lastName}"
                    : null;
            }

            return null;
        });
        ClaimActions.MapCustomJson(ClaimTypes.Email, element =>
        {
            if (element.TryGetProperty("emails", out var emailElements) && emailElements.ValueKind == JsonValueKind.Array)
            {
                var emailElement = emailElements.EnumerateArray().FirstOrDefault();
                if (emailElement.TryGetProperty("email", out var email))
                {
                    return email.GetString();
                }
            }

            return null;
        });
    }

    /// <summary>
    /// Gets or sets the Space organization URL.
    /// </summary>
    /// <remarks>
    /// When setting the organization URL, updates default values in the
    /// <see cref="OAuthOptions.AuthorizationEndpoint"/>, <see cref="OAuthOptions.TokenEndpoint"/>
    /// and <see cref="OAuthOptions.UserInformationEndpoint"/> properties.
    /// </remarks>
    [PublicAPI]
    public Uri? ServerUrl
    {
        get => _serverUrl;
        set
        {
            _serverUrl = value;

            if (_serverUrl != null)
            {
                if (AuthorizationEndpoint == SpaceDefaults.AuthorizationEndpointPath)
                {
                    AuthorizationEndpoint = _serverUrl.ToString().TrimEnd('/') + SpaceDefaults.AuthorizationEndpointPath;
                }

                if (TokenEndpoint == SpaceDefaults.TokenEndpointPath)
                {
                    TokenEndpoint = _serverUrl.ToString().TrimEnd('/') + SpaceDefaults.TokenEndpointPath;
                }

                if (UserInformationEndpoint == SpaceDefaults.UserInformationEndpointPath)
                {
                    UserInformationEndpoint = _serverUrl.ToString().TrimEnd('/') + SpaceDefaults.UserInformationEndpointPath;
                }
            }
        }
    }

    /// <summary>
    /// Request credentials behaviour. See <a href="https://www.jetbrains.com/help/space/authorization-code.html">the documentation</a> for details.
    /// </summary>
    [PublicAPI]
    public RequestCredentials RequestCredentials { get; set; } = RequestCredentials.Default;
        
    /// <summary>
    /// Gets or sets the access type. Set to <see cref="JetBrains.Space.AspNetCore.Authentication.AccessType.Offline"/> to request a refresh token.
    /// </summary>
    [PublicAPI]
    public AccessType AccessType { get; set; } = AccessType.Online;
}