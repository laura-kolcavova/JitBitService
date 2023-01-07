/// <author>
/// Laura Kolčavová, https://github.com/laura-kolcavova
/// </author>

namespace JitBitService
{
    using global::JitBitService.Responses;
    using Newtonsoft.Json;
    using System;
    using System.Collections.Generic;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Service for communicating with JitBit Helpdesk API.
    /// </summary>
    public class JitBitService : IJitBitService
    {
        /// <summary>
        /// Http client used for communiaction with JitBit Api server.
        /// </summary>
        protected readonly HttpClient httpClient;

        /// <summary>
        /// Initializes a new instance of the <see cref="JitBitService"/> class.
        /// </summary>
        /// <param name="apiUrl">API URL.</param>
        public JitBitService(string apiUrl)
        {
            httpClient = new HttpClient
            {
                BaseAddress = new Uri(apiUrl)
            };
        }

        /// <inheritdoc/>
        public void Authenticate(string username, string password)
        {
            string authenticationString = $"{username}:{password}";
            string base64EncodedAuthenticationString = Convert.ToBase64String(Encoding.ASCII.GetBytes(authenticationString));

            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", base64EncodedAuthenticationString);
        }

        /// <inheritdoc/>
        public void AuthenticateByToken(string token)
        {
            httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            httpClient.Dispose();
        }

        /// <inheritdoc/>
        public async Task<AuthorizationResponse> GetAuthorizationAsync()
        {
            var response = await httpClient.GetAsync("Authorization");
            return await ReadAsAsync<AuthorizationResponse>(response.Content);
        }

        /// <inheritdoc/>
        public async Task<TicketDetailResponse> GetTicketAsync(int ticketId)
        {
            var response = await httpClient.GetAsync("Ticket?id=" + ticketId);
            return await ReadAsAsync<TicketDetailResponse>(response.Content);
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<TicketResponse>> GetTicketsAsync()
        {
            var response = await httpClient.GetAsync("Tickets");
            return await ReadAsAsync<List<TicketResponse>>(response.Content);
        }

        /// <summary>
        /// Reads and deserialize http content into an object of specific type.
        /// </summary>
        /// <typeparam name="T">The type of the object.</typeparam>
        /// <param name="content">The http content.</param>
        /// <returns>Deserialized object.</returns>
        protected async Task<T> ReadAsAsync<T>(HttpContent content)
        {
            string json = await content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }
    }
}