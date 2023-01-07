/// <author>
/// Laura Kolčavová, https://github.com/laura-kolcavova
/// </author>

namespace JitBitService.Responses
{
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// Ticket detail response.
    /// </summary>
    public class TicketDetailResponse
    {
        /// <summary>
        /// Gets or sets AssignedToUserID.
        /// </summary>
        public int AssignedToUserID { get; set; }

        /// <summary>
        /// Gets or sets AssigneeUserInfo.
        /// </summary>
        public AssigneeUserInfoResponse AssigneeUserInfo { get; set; }

        /// <summary>
        /// Gets or sets Attachments.
        /// </summary>
        public IEnumerable<AttachmentResponse> Attachments { get; set; }

        /// <summary>
        /// Gets or sets Body.
        /// </summary>
        public string Body { get; set; }

        /// <summary>
        /// Gets or sets CategoryID.
        /// </summary>
        public int CategoryID { get; set; }

        /// <summary>
        /// Gets or sets CategoryName.
        /// </summary>
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets DueDate.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsCurrentCategoryForTechsOnly flag is set.
        /// </summary>
        public bool IsCurrentCategoryForTechsOnly { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsCurrentUserTechInThisCategory flag is set.
        /// </summary>
        public bool IsCurrentUserTechInThisCategory { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsInKb flag is set.
        /// </summary>
        public bool IsInKb { get; set; }

        /// <summary>
        /// Gets or sets IssueDate.
        /// </summary>
        public DateTime IssueDate { get; set; }

        /// <summary>
        /// Gets or sets OnBehalfUsername.
        /// </summary>
        public string OnBehalfUserName { get; set; }

        /// <summary>
        /// Gets or sets Priority.
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets ResolvedDate.
        /// </summary>
        public DateTime? ResolvedDate { get; set; }

        /// <summary>
        /// Gets or sets StartDate.
        /// </summary>
        public DateTime StartDate { get; set; }

        /// <summary>
        /// Gets or sets Stats.
        /// </summary>
        public string Stats { get; set; }

        /// <summary>
        /// Gets or sets Status.
        /// </summary>
        public string Status { get; set; }

        /// <summary>
        /// Gets or sets StatusID.
        /// </summary>
        public int StatusID { get; set; }

        /// <summary>
        /// Gets or sets Subject.
        /// </summary>
        public string Subject { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether SubmittedByCurrentUser flag is set.
        /// </summary>
        public bool SubmittedByCurrentUser { get; set; }

        /// <summary>
        /// Gets or sets SubmitterUserInfo.
        /// </summary>
        public SubmitterUserInfoResponse SubmitterUserInfo { get; set; }

        /// <summary>
        /// Gets or sets Tags.
        /// </summary>
        public IEnumerable<TagResponse> Tags { get; set; }

        /// <summary>
        /// Gets or sets TicketID.
        /// </summary>
        public int TicketID { get; set; }

        /// <summary>
        /// Gets or sets TimeSpentInSeconds.
        /// </summary>
        public int TimeSpentInSeconds { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether UpdatedByPerformer flag is set.
        /// </summary>
        public bool UpdatedByPerformer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether UpdatedByUser flag is set.
        /// </summary>
        public bool UpdatedByUser { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether UpdatedForTechView flag is set.
        /// </summary>
        public bool UpdatedForTechView { get; set; }

        /// <summary>
        /// Gets or sets UserID.
        /// </summary>
        public int UserID { get; set; }
    }
}