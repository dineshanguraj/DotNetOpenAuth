﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DotNetOpenId.Provider {
	public interface IAuthenticationRequest : IRequest {
		/// <summary>
		/// Whether the consumer demands an immediate response.
		/// If false, the consumer is willing to wait for the identity provider
		/// to authenticate the user.
		/// </summary>
		bool Immediate { get; }
		/// <summary>
		/// The URL the consumer site claims to use as its 'base' address.
		/// </summary>
		Realm Realm { get; }
		/// <summary>
		/// The local identifier to this OpenID Provider of the user attempting 
		/// to authenticate.
		/// </summary>
		/// <remarks>
		/// This may or may not be the same as the Claimed Identifier that the user agent
		/// originally supplied to the relying party.  The Claimed Identifier
		/// endpoint may be delegating authentication to this provider using
		/// this provider's local id, which is what this property contains.
		/// </remarks>
		Identifier LocalIdentifier { get; }
		/// <summary>
		/// The provider URL that responds to OpenID requests.
		/// </summary>
		/// <remarks>
		/// An auto-detect attempt is made if an ASP.NET HttpContext is available.
		/// </remarks>
		Uri ProviderEndpoint { get; set; }
		/// <summary>
		/// Gets/sets whether the provider has determined that the 
		/// <see cref="ClaimedIdentifier"/> belongs to the currently logged in user
		/// and wishes to share this information with the consumer.
		/// </summary>
		bool? IsAuthenticated { get; set; }
	}
}
