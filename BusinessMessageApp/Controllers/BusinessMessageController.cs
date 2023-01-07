using BusinessMessageApp.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace BusinessMessageApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusinessMessageController : ControllerBase
    {
        public BusinessMessageController()
        {

        }

        [HttpPost]
        public async Task<ActionResult<string>> Callback([FromBody] dynamic request)
        {
            var dict = JsonSerializer.Deserialize<Dictionary<string, string>>(request);
            var messageModel = new MessageModel();
            if (dict != null && dict.ContainsKey("clientToken"))
            {
                messageModel.ClientToken = dict["clientToken"];
            }
            if (dict != null && dict.ContainsKey("secret"))
            {
                messageModel.Secret = dict["secret"];
            }

            return Ok("secret:" + messageModel.Secret);
        }
    }
}
