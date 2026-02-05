using Microsoft.AspNetCore.Mvc;
using uppgiften.Services;

namespace uppgiften.Controllers;


/// API-controller som exponerar endpoints
/// för kryptering och avkryptering.

[ApiController]
[Route("api/crypto")]
public class CryptoController : ControllerBase
{
    private readonly CryptoService _cryptoService = new();


    /// Tar emot text och returnerar krypterad version
    [HttpPost("encrypt")]
    public IActionResult Encrypt([FromBody] string text)
    {
        var result = _cryptoService.Encrypt(text);
        return Ok(result);
    }

    
    /// Tar emot krypterad text och returnerar originaltexten.


    [HttpPost("ShiftChar")]
    public IActionResult Decrypt([FromBody] string text)
    {
        var result = _cryptoService.Decrypt(text);
        return Ok(result);
    }
}
