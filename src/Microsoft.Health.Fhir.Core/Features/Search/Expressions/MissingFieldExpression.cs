﻿// -------------------------------------------------------------------------------------------------
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License (MIT). See LICENSE in the repo root for license information.
// -------------------------------------------------------------------------------------------------

using EnsureThat;

namespace Microsoft.Health.Fhir.Core.Features.Search.Expressions
{
    /// <summary>
    /// Represents an expression that indicates the field should be missing.
    /// </summary>
    public class MissingFieldExpression : Expression, IFieldExpression
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MissingFieldExpression"/> class.
        /// </summary>
        /// <param name="fieldName">The field name.</param>
        public MissingFieldExpression(FieldName fieldName)
        {
            FieldName = fieldName;
        }

        /// <inheritdoc />
        public FieldName FieldName { get; }

        protected internal override void AcceptVisitor(IExpressionVisitor visitor)
        {
            EnsureArg.IsNotNull(visitor, nameof(visitor));

            visitor.Visit(this);
        }
    }
}
