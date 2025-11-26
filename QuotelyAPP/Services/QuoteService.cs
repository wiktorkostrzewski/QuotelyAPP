using System.Net.Http.Json;
using QuotelyAPP.Models;

namespace QuotelyAPP.Services
{
    public class QuoteService
    {
        private readonly HttpClient _http;

        public QuoteService(HttpClient http)
        {
            _http = http;
        }

        public async Task<Quote?> GetRandomQuote()
        {
            return await _http.GetFromJsonAsync<Quote>("random");
        }
        public async Task<QuoteSearchResult?> SearchQuotes(string query, int page = 1, int limit = 10)
        {
            return await _http.GetFromJsonAsync<QuoteSearchResult>(
                $"quotes?query={query}&page={page}&limit={limit}"
            );
        }
    }
}
