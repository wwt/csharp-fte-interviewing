using Microsoft.AspNetCore.Mvc;
using Api.Models;
using Data;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class HomeController : Controller
{
    private readonly IRepository _repository;

    public HomeController(IRepository repository)
    {
        _repository = repository;
    }

    [HttpPost("/albumsByArtist/{artistId}")]
    public Task<GetAlbumsByArtistResponse> GetAlbumsByArtist(int artistId)
    {
        return Task.FromResult(new GetAlbumsByArtistResponse());
    }

    [HttpPost("/searchByAlbumName/{albumName}")]
    public Task<SearchByAlbumNameResponse> SearchByAlbumName(string albumName)
    {
        return Task.FromResult(new SearchByAlbumNameResponse());
    }

    [HttpPost("/searchBySongName/{songName}")]
    public Task<SearchBySongNameResponse> SearchBySongName(string songName)
    {
        return Task.FromResult(new SearchBySongNameResponse());
    }

    [HttpPost("/albumsByYear/{year}")]
    public Task<GetAlbumsByYearResponse> GetAlbumsByYear(int year)
    {
        return Task.FromResult(new GetAlbumsByYearResponse());
    }
}
