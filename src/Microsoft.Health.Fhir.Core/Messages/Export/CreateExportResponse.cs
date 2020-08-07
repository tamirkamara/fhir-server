﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using System;
using EnsureThat;

namespace Microsoft.Health.Fhir.Core.Messages.Export
{
    public class CreateExportResponse
    {
        public CreateExportResponse(string jobId, DateTimeOffset jobTime)
        {
            EnsureArg.IsNotNullOrWhiteSpace(jobId, nameof(jobId));

            JobId = jobId;
            JobTime = jobTime;
        }

        public string JobId { get; }

        public DateTimeOffset JobTime { get; }
    }
}
