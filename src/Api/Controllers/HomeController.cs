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
        throw new NotImplementedException();
    }

    [HttpPost("/searchByAlbumName/{albumName}")]
    public Task<SearchByAlbumNameResponse> SearchByAlbumName(string albumName)
    {
        throw new NotImplementedException();
    }

    [HttpPost("/searchBySongName/{songName}")]
    public Task<SearchBySongNameResponse> SearchBySongName(string songName)
    {
        throw new NotImplementedException();
    }

    [HttpPost("/albumsByYear/{year}")]
    public Task<GetAlbumsByYearResponse> GetAlbumsByYear(int year)
    {
        throw new NotImplementedException();
    }
}
