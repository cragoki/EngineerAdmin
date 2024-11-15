namespace EngineerAdmin.Clients
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;

        public ApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        // GET Request
        public async Task<T> GetAsync<T>(string endpoint)
        {
            return await _httpClient.GetFromJsonAsync<T>(endpoint);
        }

        // POST Request
        public async Task PostNoResponseAsync<TRequest>(string endpoint, TRequest content)
        {
            await _httpClient.PostAsJsonAsync(endpoint, content);
        }
    }
}
