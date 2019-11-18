using Microsoft.AspNetCore.Mvc;

namespace Legacy.API.APIServer.Controllers.Ping
{
    [Route("ping")]
    [ApiController]
    public class PingController : ControllerBase
    {
        /// <summary>
        /// Ping API Health Check.
        /// </summary>
        /// <remarks>
        /// Ping API Health Check
        /// </remarks>
        /// <response code="200">Accepted</response>
        [HttpGet]
        public string Ping()
        {
            return "PING";
        }
    }
}