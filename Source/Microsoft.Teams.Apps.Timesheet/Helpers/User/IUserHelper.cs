﻿// <copyright file="IUserHelper.cs" company="Microsoft">
// Copyright (c) Microsoft. All rights reserved.
// </copyright>

namespace Microsoft.Teams.Apps.Timesheet.Helpers
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.Graph;

    /// <summary>
    /// Provides helper methods for fetching reportees and manager.
    /// </summary>
    public interface IUserHelper
    {
        /// <summary>
        /// Check if members are direct reportee of manager.
        /// </summary>
        /// <param name="memberIds">Ids of member.</param>
        /// <returns>Return true if members are direct reportee, else false.</returns>
        Task<bool> AreProjectMembersDirectReporteeAsync(IEnumerable<Guid> memberIds);

        /// <summary>
        /// Get direct reportees for logged in user.
        /// </summary>
        /// <param name="managerObjectId">Logged-in manager object Id.</param>
        /// <returns>List of reportees.</returns>
        Task<IEnumerable<User>> GetAllReporteesAsync(Guid managerObjectId);
    }
}