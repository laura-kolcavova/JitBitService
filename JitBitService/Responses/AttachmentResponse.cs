/// <author>
/// Laura Kolčavová, https://github.com/laura-kolcavova
/// </author>

namespace JitBitService.Responses
{
    using System;

    /// <summary>
    /// Attachment response.
    /// </summary>
    public class AttachmentResponse
    {
        /// <summary>
        /// Gets or sets CommentDate.
        /// </summary>
        public DateTime CommentDate { get; set; }

        /// <summary>
        /// Gets or sets CommentID.
        /// </summary>
        public int CommentID { get; set; }

        /// <summary>
        /// Gets or sets FileData.
        /// </summary>
        public string FileData { get; set; }

        /// <summary>
        /// Gets or sets FileHash.
        /// </summary>
        public string FileHash { get; set; }

        /// <summary>
        /// Gets or sets FileID.
        /// </summary>
        public int FileID { get; set; }

        /// <summary>
        /// Gets or sets FileName.
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets FileSize.
        /// </summary>
        public int FileSize { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether ForTechsOnly is set.
        /// </summary>
        public bool ForTechsOnly { get; set; }

        /// <summary>
        /// Gets or sets GoogleDriveUrl.
        /// </summary>
        public string GoogleDriveUrl { get; set; }

        /// <summary>
        /// Gets or sets IssueID.
        /// </summary>
        public int IssueID { get; set; }

        /// <summary>
        /// Gets or sets Url.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Gets or sets UserID.
        /// </summary>
        public int UserID { get; set; }
    }
}