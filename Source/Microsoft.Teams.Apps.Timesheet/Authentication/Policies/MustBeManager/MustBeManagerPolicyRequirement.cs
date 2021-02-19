﻿// <copyright file="MustBeManagerPolicyRequirement.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.Timesheet.Authentication
{
    using Microsoft.AspNetCore.Authorization;

    /// <summary>
    /// This authorization class implements the marker interface
    /// <see cref="IAuthorizationRequirement"/> to check if user meets reportees specific requirements
    /// for accessing resources.
    /// </summary>
    public class MustBeManagerPolicyRequirement : IAuthorizationRequirement
    {
    }
}
