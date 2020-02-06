// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Microsoft.AspNetCore.Components.WebAssembly.Authentication
{
    /// <summary>
    /// Represents options to pass down to configure the oidc-client.js library used when using a standard OIDC flow.
    /// </summary>
    public class OidcProviderOptions
    {
        /// <summary>
        /// Gets or sets the authority of the OIDC identity provider.
        /// </summary>
        public string Authority { get; set; }

        /// <summary>
        /// Gets or sets the client of the application.
        /// </summary>
        [JsonPropertyName("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// Gets or sets the list of scopes to request when signing in.
        /// </summary>
        public IList<string> DefaultScopes { get; set; } = new List<string> { "openid", "profile" };

        [JsonPropertyName("redirect_uri")]
        /// <summary>
        /// Gets or sets the redirect uri for the application. The application will be redirected here after the user has completed the sign in
        /// process from the identity provider.
        /// </summary>
        public string RedirectUri { get; set; }

        [JsonPropertyName("post_logout_redirect_uri")]
        /// <summary>
        /// Gets or sets the post logout redirect uri for the application. The application will be redirected here after the user has completed the sign out
        /// process from the identity provider.
        /// </summary>
        public string PostLogoutRedirectUri { get; set; }
    }
}
