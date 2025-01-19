using AuthService.Domain.Abstractions;
using AuthServiceContracts.User;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace AuthService.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController(IAuthenticationService service, ILogger<UserController> logger, IMapper mapper) : ControllerBase
{
    private readonly IAuthenticationService _service = service;
    private readonly ILogger<UserController> _logger = logger;
    private readonly IMapper _mapper = mapper;

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAsync(string id, CancellationToken cancellationToken)
    {
        _logger.LogInformation($"Получение пользователя с id {id}");
        return Ok(_mapper.Map<UserDto>(await _service.Login(id, cancellationToken)));
    }
}
