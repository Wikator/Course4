using AutoMapper;
using Blazored.LocalStorage;
using BookStoreApp.Blazor.Server.UI.Services.Base;

namespace BookStoreApp.Blazor.Server.UI.Services;

public class AuthorService : BaseHttpService, IAuthorService
{
    private readonly IClient _client;
    private readonly IMapper _mapper;

    public AuthorService(IClient client,
        ILocalStorageService localStorage,
        IMapper mapper) : base(client, localStorage)
    {
        _client = client;
        _mapper = mapper;
    }


    public async Task<Response<List<AuthorReadOnlyDto>>> GetAuthors()
    {
        Response<List<AuthorReadOnlyDto>> response;

        try
        {
            await GetBearerToken();
            var data = await _client.AuthorsAllAsync( );
            response = new Response<List<AuthorReadOnlyDto>>
            {
                Data = data.ToList(),
                IsSuccess = true
            };
        }
        catch (ApiException ex)
        {
            response = ConvertApiExceptions<List<AuthorReadOnlyDto>>(ex);
        }

        return response;
    }

    public async Task<Response<AuthorReadOnlyDto>> GetAuthor(int id)
    {
        Response<AuthorReadOnlyDto> response;

        try
        {
            await GetBearerToken();
            var data = await _client.AuthorsGETAsync(id);
            response = new Response<AuthorReadOnlyDto>
            {
                Data = data,
                IsSuccess = true
            };
        }
        catch (ApiException ex)
        {
            response = ConvertApiExceptions<AuthorReadOnlyDto>(ex);
        }

        return response;
    }

    public async Task<Response<AuthorUpdateDto>> GetAuthorForUpdate(int id)
    {
        Response<AuthorUpdateDto> response;

        try
        {
            await GetBearerToken();
            var data = await _client.AuthorsGETAsync(id);
            response = new Response<AuthorUpdateDto>
            {
                Data = _mapper.Map<AuthorUpdateDto>(data),
                IsSuccess = true
            };
        }
        catch (ApiException ex)
        {
            response = ConvertApiExceptions<AuthorUpdateDto>(ex);
        }

        return response;
    }

    public async Task<Response<int>> CreateAuthor(AuthorCreateDto author)
    {
        var response = new Response<int>();
        
        try
        {
            await GetBearerToken();
            await _client.AuthorsPOSTAsync(author);
        }
        catch (ApiException ex)
        {
            response = ConvertApiExceptions<int>(ex);
        }

        return response;
    }

    public async Task<Response<int>> EditAuthor(int id, AuthorUpdateDto author)
    {
        var response = new Response<int>();
        
        try
        {
            await GetBearerToken();
            await _client.AuthorsPUTAsync(id, author);
        }
        catch (ApiException ex)
        {
            response = ConvertApiExceptions<int>(ex);
        }

        return response;
    }
}
