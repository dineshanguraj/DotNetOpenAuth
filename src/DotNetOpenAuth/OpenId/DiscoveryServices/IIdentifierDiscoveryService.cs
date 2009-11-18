﻿//-----------------------------------------------------------------------
// <copyright file="IIdentifierDiscoveryService.cs" company="Andrew Arnott">
//     Copyright (c) Andrew Arnott. All rights reserved.
// </copyright>
//-----------------------------------------------------------------------

namespace DotNetOpenAuth.OpenId.DiscoveryServices {
	using System;
	using System.Collections.Generic;
	using System.Diagnostics.Contracts;
	using System.Linq;
	using System.Text;
	using DotNetOpenAuth.Messaging;
	using DotNetOpenAuth.OpenId.RelyingParty;

	/// <summary>
	/// A module that provides discovery services for OpenID identifiers.
	/// </summary>
	[ContractClass(typeof(IIdentifierDiscoveryServiceContract))]
	internal interface IIdentifierDiscoveryService {
		/// <summary>
		/// Performs discovery on the specified identifier.
		/// </summary>
		/// <param name="identifier">The identifier to perform discovery on.</param>
		/// <param name="requestHandler">The means to place outgoing HTTP requests.</param>
		/// <param name="abortDiscoveryChain">if set to <c>true</c>, no further discovery services will be called for this identifier.</param>
		/// <returns>
		/// A sequence of service endpoints yielded by discovery.  Must not be null, but may be empty.
		/// </returns>
		[Pure]
		IEnumerable<ServiceEndpoint> Discover(Identifier identifier, IDirectWebRequestHandler requestHandler, out bool abortDiscoveryChain);
	}

	/// <summary>
	/// Code contract for the <see cref="IIdentifierDiscoveryService"/> interface.
	/// </summary>
	[ContractClassFor(typeof(IIdentifierDiscoveryService))]
	internal class IIdentifierDiscoveryServiceContract : IIdentifierDiscoveryService {
		#region IDiscoveryService Members

		/// <summary>
		/// Performs discovery on the specified identifier.
		/// </summary>
		/// <param name="identifier">The identifier to perform discovery on.</param>
		/// <param name="requestHandler">The means to place outgoing HTTP requests.</param>
		/// <param name="abortDiscoveryChain">if set to <c>true</c>, no further discovery services will be called for this identifier.</param>
		/// <returns>
		/// A sequence of service endpoints yielded by discovery.  Must not be null, but may be empty.
		/// </returns>
		IEnumerable<ServiceEndpoint> IIdentifierDiscoveryService.Discover(Identifier identifier, IDirectWebRequestHandler requestHandler, out bool abortDiscoveryChain) {
			Contract.Requires<ArgumentNullException>(identifier != null);
			Contract.Requires<ArgumentNullException>(requestHandler != null);
			Contract.Ensures(Contract.Result<IEnumerable<ServiceEndpoint>>() != null);
			throw new NotImplementedException();
		}

		#endregion
	}
}