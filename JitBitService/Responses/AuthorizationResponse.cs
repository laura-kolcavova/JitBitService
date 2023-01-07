/// <author>
/// Laura Kolčavová, https://github.com/laura-kolcavova
/// </author>

namespace JitBitService.Responses
{
    using System;

    /// <summary>
    /// Authorization response.
    /// </summary>
    public class AuthorizationResponse
    {
        /// <summary>
        /// Gets or sets AvatrURL.
        /// </summary>
        public string AvatarURL { get; set; }

        /// <summary>
        /// Gets or sets CompanyId.
        /// </summary>
        public int? CompanyId { get; set; }

        /// <summary>
        /// Gets or sets CompanyName.
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Gets or sets Department.
        /// </summary>
        public string Department { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether Disabled flag is set.
        /// </summary>
        public bool Disabled { get; set; }

        /// <summary>
        /// Gets or sets Email.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets FirstName.
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets Greeting.
        /// </summary>
        public string Greeting { get; set; }

        /// <summary>
        /// Gets or sets HostName.
        /// </summary>
        public string HostName { get; set; }

        /// <summary>
        /// Gets or sets IPAddress.
        /// </summary>
        public string IPAddress { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsAdmin flag is set.
        /// </summary>
        public bool IsAdmin { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsManager flag is set.
        /// </summary>
        public bool IsManager { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether IsTech flag is set.
        /// </summary>
        public bool IsTech { get; set; }

        /// <summary>
        /// Gets or sets Lang.
        /// </summary>
        public string Lang { get; set; }

        /// <summary>
        /// Gets or sets LastName.
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets LastSeen.
        /// </summary>
        public DateTime LastSeen { get; set; }

        /// <summary>
        /// Gets or sets Location.
        /// </summary>
        public string Location { get; set; }

        /// <summary>
        /// Gets or sets Notes.
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Gets or sets Phone.
        /// </summary>
        public string Phone { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether SendEmail flag is set.
        /// </summary>
        public bool SendEmail { get; set; }

        /// <summary>
        /// Gets or sets Signature.
        /// </summary>
        public string Signature { get; set; }

        /// <summary>
        /// Gets or sets UserAgent.
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Gets or sets UserID.
        /// </summary>
        public int UserID { get; set; }

        /// <summary>
        /// Gets or sets Username.
        /// </summary>
        public string Username { get; set; }
    }
}