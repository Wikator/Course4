using System.Net.Http.Headers;
using Blazored.LocalStorage;

namespace BookStoreApp.Blazor.Server.UI.Services.Base;

public class BaseHttpService
{
    private readonly IClient _client;
    private readonly ILocalStorageService _localStorage;

    protected BaseHttpService(IClient client,
        ILocalStorageService localStorage)
    {
        _client = client;
        _localStorage = localStorage;
    }
    
    protected static Response<Guid> ConvertApiExceptions<Guid>(ApiException apiException)
    {
        return apiException.StatusCode switch
        {
            201 => new Response<Guid>
            {
                Message = "Operation completed successfully.",
                IsSuccess = true
            },
            204 => new Response<Guid>
            {
                Message = "Operation completed successfully.",
                IsSuccess = true
            },
            400 => new Response<Guid>
            {
                Message = "Validation errors have occured.",
                ValidationErrors = apiException.Response,
                IsSuccess = false
            },
            404 => new Response<Guid> { Message = "The requested item could not be found.", IsSuccess = false },
            _ => new Response<Guid> { Message = "Something went wrong, please try again later.", IsSuccess = false }
        };
    }

    protected async Task GetBearerToken()
    {
        var token = await _localStorage.GetItemAsync<string>("accessToken");
        
        if (!string.IsNullOrEmpty(token))
        {
            _client.HttpClient.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", token);
        }
    }
}