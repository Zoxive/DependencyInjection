// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

namespace Microsoft.Extensions.DependencyInjection
{
    /// <inheritdoc />
    public enum ServiceProviderMode
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        Dynamic,
        Runtime,
        Expressions,
        ILEmit
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    }
}