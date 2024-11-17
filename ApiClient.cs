using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using System.Text.Json;

class ApiClient
{
    private readonly HttpClient _httpClient;
    private const string API_URL = "https://opentdb.com/api.php";

    public ApiClient()
    {
        _httpClient = new HttpClient();
    }

    public async Task<List<Question>> FetchQuestions(int amount)
    {
        var response = await _httpClient.GetStringAsync($"{API_URL}?amount={amount}&type=boolean");
        var apiResponse = JsonSerializer.Deserialize<ApiResponse>(response);
        return apiResponse.Results;
    }
}

class ApiResponse
{
    public List<Question> Results { get; set; }
}