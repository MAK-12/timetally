﻿// <copyright file="MustBeProjectCreatorRequirement.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.Timesheet.Authentication
{
    using Microsoft.AspNetCore.Authorization;

    /// <summary>
    /// This authorization class implements the marker interface
    /// <see cref="IAuthorizationRequirement"/> to check if user has created project requirement
    /// for accessing resources.
    /// </summary>
    public class MustBeProjectCreatorRequirement : IAuthorizationRequirement
    {
    }
}
