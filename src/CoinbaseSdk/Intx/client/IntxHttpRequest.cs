namespace CoinbaseSdk.Intx.Client
{
  using CoinbaseSdk.Core.Credentials;
  using CoinbaseSdk.Core.Http;
  using CoinbaseSdk.Core.Serialization;

  public class IntxHttpRequest(
      string path,
      string method,
      CoinbaseCredentials credentials,
      object request,
      IJsonUtility jsonUtility)
: CoinbaseHttpRequest(path, method, credentials, request, jsonUtility)
  {
    protected override Dictionary<string, string> BuildHeaders(string path, string method, CoinbaseCredentials credentials)
    {
      var headers = new Dictionary<string, string>();

      // generate a timestamp and use that in both sign and the timestamp header
      var timestamp = DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString();

      headers.Add("CB-ACCESS-KEY", credentials.AccessKey);
      headers.Add("CB-ACCESS-SIGN", credentials.Sign(timestamp, method, path, this.Content));
      headers.Add("CB-ACCESS-TIMESTAMP", timestamp);
      headers.Add("CB-ACCESS-PASSPHRASE", credentials.Passphrase);
      headers.Add("User-Agent", "CoinbaseIntxDotnet/0.1");

      return headers;
    }
  }
}
