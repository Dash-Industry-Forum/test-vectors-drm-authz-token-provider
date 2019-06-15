DASH-IF test vector authorization token provider
================================================

Implements the license request authorization protocol described in https://github.com/Dash-Industry-Forum/DASH-IF-IOP/issues/300 and supplies authorization tokens to clients.

Supported authorization mechanisms
==================================

1. Predefined tokens.

In the future, other mechanisms may also be added (dynamically generated tokens).

Usage: predefined tokens
========================

1. Edit `PredefinedTokens.cs` and add your token together with a unique name.
1. Provide clients an `<dashif:authzurl>` element with the value `https://dashif-test-vectors-authz.azurewebsites.net/Authorize/ByPredefinedTokenId/xyz` where `xyz` is the unique name of your token.

Adding more tokens
==================

If you have commit access, just add them. If not, make a pull request.

Updates will go live within a 5 minutes of being committed.