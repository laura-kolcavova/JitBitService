/// <author>
/// Laura Kolčavová, https://github.com/laura-kolcavova
/// </author>

namespace JitBitService
{
    using global::JitBitService.Responses;
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IJitBitService : IDisposable
    {
        /// <summary>
        /// Authenticates an user.
        /// </summary>
        /// <param name="username">Username.</param>
        /// <param name="password">Passowrd.</param>
        void Authenticate(string username, string password);

        /// <summary>
        /// Authenticates an user by token.
        /// </summary>
        /// <param name="token">Token.</param>
        void AuthenticateByToken(string token);

        /// <summary>
        /// The method returns a helpdesk "user" object asynchronously.
        /// </summary>
        /// <returns>Response.</returns>
        Task<AuthorizationResponse> GetAuthorizationAsync();

        /// <summary>
        /// Gets details of a ticket asynchronously.
        /// </summary>
        /// <param name="ticketId">Ticket id.</param>
        /// <returns>Response.</returns>
        Task<TicketDetailResponse> GetTicketAsync(int ticketId);

        /// <summary>
        /// Gets a list of tickets the current user has permissions to see asynchronously.
        /// </summary>
        /// <returns>Response.</returns>
        Task<IEnumerable<TicketResponse>> GetTicketsAsync();
    }
}