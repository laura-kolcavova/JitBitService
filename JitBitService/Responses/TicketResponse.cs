/// <author>
/// Laura Kolčavová, https://github.com/laura-kolcavova
/// </author>

namespace JitBitService.Responses
{
    using System;

    /// <summary>
    /// Ticket response.
    /// </summary>
    public class TicketResponse
    {
        /// <summary>
        /// Gets or sets AssignedToUserID.
        /// </summary>
        public int? AssignedToUserID { get; set; }

        /// <summary>
        /// Gets or sets Category.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Gets or sets CategoryID.
        /// </summary>
        public int CategoryID { get; set; }

        /// <summary>
        /// Gets or sets CompanyID.
        /// </summary>
        public int? CompanyID { get; set; }

        /// <summary>
        /// Gets or sets CompanyName.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets DueDate.
        /// </summary>
        public DateTime? DueDate { get; set; }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets IssueDate.
        /// </summary>
        public DateTime IssueDate { get; set; }

        /// <summary>
        /// Gets or sets IssueID.
        /// </summary>
        public int IssueID { get; set; }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets LastUpdated.
        /// </summary>
        public DateTime LastUpdated { get; set; }

        /// <summary>
        /// Gets or sets Priority.
        /// </summary>
        public int Priority { get; set; }

        /// <summary>
        /// Gets or sets SectionID.
        /// </summary>
        public int? SectionID { get; set; }

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
        /// Gets or sets TechFirstName.
        /// </summary>
        public string TechFirstName { get; set; }

        /// <summary>
        /// Gets or sets TechnicianLastName.
        /// </summary>
        public string TechLastName { get; set; }

        /// <summary>
        /// Gets or sets Technician.
        /// </summary>
        public string Technician { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether UpdatedByPerformer is set.
        /// </summary>
        public bool UpdatedByPerformer { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether UpdatedByUser is set.
        /// </summary>
        public bool UpdatedByUser { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether UpdatedForTechView is set.
        /// </summary>
        public bool UpdatedForTechView { get; set; }

        /// <summary>
        /// Gets or sets UserID.
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets UserName.
        /// </summary>
        public string UserName { get; set; }
    }
}