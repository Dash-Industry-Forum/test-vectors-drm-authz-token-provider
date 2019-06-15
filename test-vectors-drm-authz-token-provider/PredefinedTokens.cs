using System.Collections.Generic;

namespace test_vectors_drm_authz_token_provider
{
    /// <summary>
    /// Just add your tokens here and that's it.
    /// </summary>
    public static class PredefinedTokens
    {
        public static readonly Dictionary<string, string> Tokens = new Dictionary<string, string>
        {
            { "development_dummy_token_1", "not_a_real_token" }
        };
    }
}
