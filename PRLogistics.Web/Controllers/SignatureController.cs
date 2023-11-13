using Microsoft.AspNetCore.Mvc;
using PRLogistics.Web.Models;
using PRLogistics.Web.Services;

namespace PRLogistics.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SignatureController : ControllerBase
    {
        private readonly ISignatureService _signatureService;

        public SignatureController(ISignatureService signatureService)
        {
            _signatureService = signatureService;
        }

        [HttpGet("welcome")]
        public string GetWelcomeMessage()
        {
            return "Welcome";
        }

        [HttpPost("save")]
        public async Task<bool> SaveSignatureData([FromForm] SignatureDto dto)
        {
            return await _signatureService.SaveSignatureDataIntoSharePoint(dto);
        }
    }
}