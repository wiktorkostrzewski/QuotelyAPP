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
    }
}
