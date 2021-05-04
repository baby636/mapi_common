﻿// Copyright(c) 2020 Bitcoin Association.
// Distributed under the Open BSV software license, see the accompanying file LICENSE

using Microsoft.AspNetCore.Authentication;

namespace MerchantAPI.Common.Authentication
{
  public class ApiKeyAuthenticationOptions : AuthenticationSchemeOptions
  {
    public const string DefaultScheme = "API Key";
    public string Scheme => DefaultScheme;
    public string AuthenticationType = DefaultScheme;
  }
}
