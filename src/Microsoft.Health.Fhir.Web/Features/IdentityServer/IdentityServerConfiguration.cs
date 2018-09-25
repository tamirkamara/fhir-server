﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

namespace Microsoft.Health.Fhir.Web.Features.IdentityServer
{
    public class IdentityServerConfiguration
    {
        public bool Enabled { get; set; }

        public string Audience { get; set; }

        public string ClientId { get; set; }

        public string ClientSecret { get; set; }
    }
}