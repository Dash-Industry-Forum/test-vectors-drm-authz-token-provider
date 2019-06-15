using Microsoft.AspNetCore.Mvc;

namespace test_vectors_drm_authz_token_provider.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class AuthorizeController : ControllerBase
    {
        /// <summary>
        /// Always returns the same token based on the provided ID.
        /// </summary>
        [HttpGet("ByPredefinedTokenId/{id}")]
        public ActionResult<string> Get(string id)
        {
            if (PredefinedTokens.Tokens.ContainsKey(id))
                return PredefinedTokens.Tokens[id];

            return NotFound();
        }

        // TODO: Implement a mechanism to authorize a set of requested KIDs, for additional testing scenarios.
    }
}
